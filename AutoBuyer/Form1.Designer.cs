namespace AutoBuyer
{
    partial class AutoBuyerMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoBuyerMainForm));
            button_start = new Button();
            key_input = new TextBox();
            name_input = new TextBox();
            price_input = new TextBox();
            link = new LinkLabel();
            outcome_label = new Label();
            name_text = new Label();
            key_label = new Label();
            price_label = new Label();
            progressBar = new ProgressBar();
            status_label = new Label();
            stop_button = new Button();
            loading_timer = new System.Windows.Forms.Timer(components);
            delay_timer = new System.Windows.Forms.Timer(components);
            time_text = new TextBox();
            time_label = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            close_box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_box).BeginInit();
            SuspendLayout();
            // 
            // button_start
            // 
            button_start.BackColor = Color.Transparent;
            button_start.BackgroundImageLayout = ImageLayout.Stretch;
            button_start.FlatAppearance.BorderSize = 0;
            button_start.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_start.ForeColor = Color.Black;
            button_start.Location = new Point(1025, 503);
            button_start.Margin = new Padding(4);
            button_start.Name = "button_start";
            button_start.Size = new Size(313, 114);
            button_start.TabIndex = 0;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // key_input
            // 
            key_input.BackColor = SystemColors.ControlLight;
            key_input.BorderStyle = BorderStyle.None;
            key_input.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            key_input.Location = new Point(189, 101);
            key_input.Margin = new Padding(4);
            key_input.Name = "key_input";
            key_input.Size = new Size(362, 28);
            key_input.TabIndex = 1;
            key_input.TextChanged += key_input_TextChanged;
            key_input.Enter += key_input_TextChanged;
            key_input.Leave += key_input_TextChanged;
            // 
            // name_input
            // 
            name_input.BackColor = SystemColors.ControlLight;
            name_input.BorderStyle = BorderStyle.None;
            name_input.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            name_input.Location = new Point(559, 101);
            name_input.Margin = new Padding(4);
            name_input.Name = "name_input";
            name_input.Size = new Size(410, 28);
            name_input.TabIndex = 2;
            name_input.TextChanged += name_input_TextChanged;
            name_input.Enter += name_input_TextChanged;
            name_input.Leave += name_input_TextChanged;
            // 
            // price_input
            // 
            price_input.BackColor = SystemColors.ControlLight;
            price_input.BorderStyle = BorderStyle.None;
            price_input.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            price_input.Location = new Point(977, 101);
            price_input.Margin = new Padding(4);
            price_input.Name = "price_input";
            price_input.Size = new Size(164, 28);
            price_input.TabIndex = 3;
            price_input.TextChanged += price_input_TextChanged;
            price_input.Enter += price_input_TextChanged;
            price_input.Leave += price_input_TextChanged;
            // 
            // link
            // 
            link.BackColor = Color.Transparent;
            link.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            link.ForeColor = Color.Black;
            link.LinkColor = Color.Black;
            link.Location = new Point(1, 682);
            link.Margin = new Padding(4, 0, 4, 0);
            link.Name = "link";
            link.Size = new Size(932, 93);
            link.TabIndex = 4;
            link.TabStop = true;
            link.Text = "https://market.csgo.com/api/v2/buy?key={KEY}&hash_name={NAME}&price={PRICE}";
            link.VisitedLinkColor = Color.Gray;
            // 
            // outcome_label
            // 
            outcome_label.BackColor = Color.Transparent;
            outcome_label.Font = new Font("Bahnschrift SemiBold", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            outcome_label.Location = new Point(1, 632);
            outcome_label.Margin = new Padding(4, 0, 4, 0);
            outcome_label.Name = "outcome_label";
            outcome_label.Size = new Size(333, 50);
            outcome_label.TabIndex = 5;
            outcome_label.Text = "Outcome API link:";
            // 
            // name_text
            // 
            name_text.AutoSize = true;
            name_text.BackColor = Color.White;
            name_text.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            name_text.ForeColor = Color.Gray;
            name_text.Location = new Point(719, 70);
            name_text.Margin = new Padding(4, 0, 4, 0);
            name_text.Name = "name_text";
            name_text.Size = new Size(72, 28);
            name_text.TabIndex = 6;
            name_text.Text = "Name";
            // 
            // key_label
            // 
            key_label.AutoSize = true;
            key_label.BackColor = Color.White;
            key_label.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            key_label.ForeColor = Color.Gray;
            key_label.Location = new Point(324, 68);
            key_label.Margin = new Padding(4, 0, 4, 0);
            key_label.Name = "key_label";
            key_label.Size = new Size(50, 28);
            key_label.TabIndex = 7;
            key_label.Text = "Key";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.BackColor = Color.White;
            price_label.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            price_label.ForeColor = Color.Gray;
            price_label.Location = new Point(1025, 70);
            price_label.Margin = new Padding(4, 0, 4, 0);
            price_label.Name = "price_label";
            price_label.Size = new Size(64, 28);
            price_label.TabIndex = 8;
            price_label.Text = "Price";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(-8, 30);
            progressBar.Margin = new Padding(4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1385, 36);
            progressBar.TabIndex = 9;
            // 
            // status_label
            // 
            status_label.BackColor = Color.FromArgb(63, 33, 56);
            status_label.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            status_label.ForeColor = Color.Khaki;
            status_label.Location = new Point(1, 1);
            status_label.Margin = new Padding(4, 0, 4, 0);
            status_label.Name = "status_label";
            status_label.Size = new Size(1376, 29);
            status_label.TabIndex = 0;
            status_label.Text = "Status Feedback";
            status_label.TextAlign = ContentAlignment.TopCenter;
            status_label.MouseDown += status_label_MouseDown;
            status_label.MouseMove += status_label_MouseMove;
            // 
            // stop_button
            // 
            stop_button.BackColor = Color.Transparent;
            stop_button.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            stop_button.Location = new Point(1025, 644);
            stop_button.Margin = new Padding(4);
            stop_button.Name = "stop_button";
            stop_button.Size = new Size(313, 59);
            stop_button.TabIndex = 11;
            stop_button.Text = "Stop";
            stop_button.UseVisualStyleBackColor = false;
            stop_button.Click += stop_button_Click;
            // 
            // loading_timer
            // 
            loading_timer.Interval = 10;
            loading_timer.Tick += loading_timer_Tick;
            // 
            // delay_timer
            // 
            delay_timer.Interval = 3000;
            delay_timer.Tick += delay_timer_Tick;
            // 
            // time_text
            // 
            time_text.BackColor = SystemColors.ControlLight;
            time_text.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            time_text.Location = new Point(1209, 734);
            time_text.Margin = new Padding(4);
            time_text.Name = "time_text";
            time_text.Size = new Size(129, 35);
            time_text.TabIndex = 12;
            time_text.Text = "3000";
            time_text.TextChanged += time_text_TextChanged;
            // 
            // time_label
            // 
            time_label.BackColor = Color.White;
            time_label.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time_label.ForeColor = Color.DimGray;
            time_label.Location = new Point(977, 734);
            time_label.Margin = new Padding(4, 0, 4, 0);
            time_label.Name = "time_label";
            time_label.Size = new Size(262, 35);
            time_label.TabIndex = 13;
            time_label.Text = "Request delay (ms):";
            time_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources._back_light;
            pictureBox1.Location = new Point(940, 435);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 363);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._back_light;
            pictureBox2.Location = new Point(158, -846);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1023, 1052);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // close_box
            // 
            close_box.BackColor = Color.FromArgb(63, 33, 56);
            close_box.BackgroundImage = Properties.Resources.StarWhite;
            close_box.BackgroundImageLayout = ImageLayout.Zoom;
            close_box.Image = Properties.Resources.StarWhite;
            close_box.Location = new Point(1343, 1);
            close_box.Name = "close_box";
            close_box.Size = new Size(32, 29);
            close_box.TabIndex = 16;
            close_box.TabStop = false;
            close_box.Click += close_box_Click;
            // 
            // AutoBuyerMainForm
            // 
            AccessibleName = "Market AutoBuyer";
            AccessibleRole = AccessibleRole.Application;
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1376, 784);
            ControlBox = false;
            Controls.Add(close_box);
            Controls.Add(progressBar);
            Controls.Add(status_label);
            Controls.Add(outcome_label);
            Controls.Add(link);
            Controls.Add(time_text);
            Controls.Add(time_label);
            Controls.Add(button_start);
            Controls.Add(stop_button);
            Controls.Add(pictureBox1);
            Controls.Add(price_label);
            Controls.Add(key_label);
            Controls.Add(name_text);
            Controls.Add(price_input);
            Controls.Add(name_input);
            Controls.Add(key_input);
            Controls.Add(pictureBox2);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AutoBuyerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market AutoBuyer @MentallyStable4Sure";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_start;
        private TextBox key_input;
        private TextBox name_input;
        private TextBox price_input;
        private LinkLabel link;
        private Label outcome_label;
        private Label name_text;
        private Label key_label;
        private Label price_label;
        private ProgressBar progressBar;
        private Label status_label;
        private Button stop_button;
        private System.Windows.Forms.Timer loading_timer;
        private System.Windows.Forms.Timer delay_timer;
        private TextBox time_text;
        private Label time_label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox close_box;
    }
}