using AutoBuyer.Data;
using AutoBuyer.Requests;
using AutoBuyer.Utility;

namespace AutoBuyer
{
    public partial class AutoBuyerMainForm : Form
    {
        private System.Uri uri;
        private HttpClient client;

        private Database database;
        private RequestsHandler requestsHandler;

        private Drag drag;

        public bool IsBuying { get; private set; }

        public AutoBuyerMainForm()
        {
            InitializeComponent();
            database = new Database();
            requestsHandler = new RequestsHandler();

            requestsHandler.FeedbackHandler.OnFeedbackUpdated += UpdateStatus;

            drag = new Drag();
        }

        private void StartLoop()
        {
            uri = RequestsHandler.UpdateLinkAccordingToRequest(database.Link);
            link_text.Text = uri.ToString(); //debug link

            client = new HttpClient();
            delay_timer.Start();
        }

        private void UpdateLoadingBar(MarketResponse response)
        {
            var feedbackHandler = requestsHandler.FeedbackHandler;

            if (response == null) feedbackHandler.UpdateFeedback(RequestsHandler.DeserializationError);
            else feedbackHandler.UpdateFeedback(response.Status ? FeedbackHandler.MessageBought : FeedbackHandler.MessageNotBought);


            ResetTimer();
            loading_timer.Start();
        }

        private void UpdateStatus(string feedback) => status_label.Text = feedback;

        private void ResetTimer()
        {
            progressBar.Value = 0;
            loading_timer.Stop();
        }


        private void name_input_TextChanged(object sender, EventArgs e) => database.Link.Name = name_input.Text;

        private void key_input_TextChanged(object sender, EventArgs e) => database.Link.Key = key_input.Text;

        private void price_input_TextChanged(object sender, EventArgs e) => database.Link.Price = price_input.Text;

        private void button_start_Click(object sender, EventArgs e)
        {
            IsBuying = true;
            StartLoop();
        }


        private void loading_timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100) return;
            progressBar.Value += 5;
        }

        private void delay_timer_Tick(object sender, EventArgs e)
        {
            if (!IsBuying)
            {
                delay_timer.Stop();
                link_text.Text = string.Empty;
                client.Dispose();
                return;
            }

            requestsHandler.SendMarketRequest(client, uri, UpdateLoadingBar).ConfigureAwait(false);
        }

        private void time_text_TextChanged(object sender, EventArgs e) => delay_timer.Interval = int.Parse(time_text.Text);

        private void stop_button_Click(object sender, EventArgs e)
        {
            IsBuying = false;
            ResetTimer();
        }

        private void close_box_Click(object sender, EventArgs e)
        {
            requestsHandler.FeedbackHandler.OnFeedbackUpdated -= UpdateStatus;

            Application.Exit();
        }

        private void status_label_MouseDown(object sender, MouseEventArgs e) => drag.SetStartPoint(-e.X, -e.Y);

        private void status_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Location = drag.MouseDrag(MousePosition);
        }

        private void dropdown_menu_ItemChanged(object sender, EventArgs e) => database.Link.RequestType = (RequestType)dropdown_menu.SelectedIndex;
    }
}