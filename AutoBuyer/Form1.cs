using AutoBuyer.Items;
using System;
using System.Net;

namespace AutoBuyer
{
    public partial class AutoBuyerMainForm : Form
    {
        public const string baseUrl = "https://market.csgo.com/api/v2/buy?key=";
        public const string nameUrl = "&hash_name=";
        public const string priceUrl = "&price=";


        private System.Uri uri;
        private HttpClient client;

        private LinkItem linkItem;

        public bool IsBuying { get; private set; }

        public AutoBuyerMainForm()
        {
            linkItem = new LinkItem(string.Empty, string.Empty, string.Empty);
            InitializeComponent();
        }

        private void name_input_TextChanged(object sender, EventArgs e)
        {
            linkItem.Name = name_input.Text;
            UpdateLink(link);
        }

        private void key_input_TextChanged(object sender, EventArgs e)
        {
            linkItem.Key = key_input.Text;
            UpdateLink(link);
        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {
            linkItem.Price = price_input.Text;
            UpdateLink(link);
        }

        private void UpdateLink(LinkLabel link) => link.Text = $"{baseUrl}{linkItem.Key}{nameUrl}{linkItem.Name}{priceUrl}{linkItem.Price}";

        private void button_start_Click(object sender, EventArgs e)
        {
            IsBuying = true;

            StartLoop();
        }

        private void StartLoop()
        {
            uri = new System.Uri(link.Text);
            client = new HttpClient();

            delay_timer.Start();
        }

        private async Task SendResponse()
        {
            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, uri));

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = response.Content.ReadAsStringAsync();
                UpdateLoadingBar(result);

                var resultContent = await result;
                var responseResult = Newtonsoft.Json.JsonConvert.DeserializeObject<MarketResponse>(resultContent);

                if (responseResult == null) return;
                status_label.Text = responseResult.Status ? "Item bought successfully!" : "Item not bought";
            }
            else
            {
                status_label.Text = "Error occurred while buying an item";
            }
        }

        private void UpdateLoadingBar(Task<string> result)
        {
            ResetTimer();
            loading_timer.Start();
        }

        private void ResetTimer()
        {
            progressBar.Value = 0;
            loading_timer.Stop();
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
                client.Dispose();
                return;
            }

            SendResponse().ConfigureAwait(false);
        }

        private void time_text_TextChanged(object sender, EventArgs e)
        {
            delay_timer.Interval = int.Parse(time_text.Text);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            IsBuying = false;
            ResetTimer();
        }

        private void close_box_Click(object sender, EventArgs e) => Application.Exit();
    }
}