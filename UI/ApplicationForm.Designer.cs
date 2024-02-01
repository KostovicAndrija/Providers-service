namespace UI
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProviderName = new Panel();
            ProviderNameLabel = new Label();
            RegistrationPanel = new Panel();
            LabelInternetSpeed = new Label();
            LabelNumberChannels = new Label();
            LabelPacketPrice = new Label();
            LabelPacketName = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            UsernameLabel = new Label();
            ClientInformationPanel = new Panel();
            LastPriceToPayLabel = new Label();
            PriceToPayValue = new Label();
            SurnameValueLabel = new Label();
            NameValueLabel = new Label();
            LastPriceToPay = new Label();
            PriceToPayLabel = new Label();
            SurnameLabel = new Label();
            LabelName = new Label();
            ClientInformationLabel = new Label();
            InternetSpeedLabel = new TextBox();
            AddPacketLabel = new Button();
            NumberOfChannelsLabel = new TextBox();
            PacketPriceLabel = new TextBox();
            PacketNameLabel = new TextBox();
            RegisterNewPacketLabel = new Label();
            AddClientButton = new Button();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            RegistrationLabel = new Label();
            ClientPanel = new Panel();
            ListOfClientsPanel = new FlowLayoutPanel();
            ClientLabel = new Label();
            TvPacketPanel = new Panel();
            ListOfTvPacketPanel = new FlowLayoutPanel();
            TvPacketLabel = new Label();
            InternetPacketPanel = new Panel();
            ListOfInternetPacketPanel = new FlowLayoutPanel();
            InternetPacketLabel = new Label();
            CombinedPacketPanel = new Panel();
            ListOfCombinedPacketPanel = new FlowLayoutPanel();
            CombinePacketLabel = new Label();
            ProviderName.SuspendLayout();
            RegistrationPanel.SuspendLayout();
            ClientInformationPanel.SuspendLayout();
            ClientPanel.SuspendLayout();
            TvPacketPanel.SuspendLayout();
            InternetPacketPanel.SuspendLayout();
            CombinedPacketPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProviderName
            // 
            ProviderName.BackColor = Color.FromArgb(192, 255, 192);
            ProviderName.BorderStyle = BorderStyle.FixedSingle;
            ProviderName.Controls.Add(ProviderNameLabel);
            ProviderName.Dock = DockStyle.Top;
            ProviderName.Location = new Point(0, 0);
            ProviderName.Name = "ProviderName";
            ProviderName.Size = new Size(1121, 33);
            ProviderName.TabIndex = 0;
            ProviderName.Paint += ProviderName_Paint;
            // 
            // ProviderNameLabel
            // 
            ProviderNameLabel.Anchor = AnchorStyles.None;
            ProviderNameLabel.AutoSize = true;
            ProviderNameLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProviderNameLabel.ForeColor = Color.Black;
            ProviderNameLabel.Location = new Point(65, 5);
            ProviderNameLabel.Name = "ProviderNameLabel";
            ProviderNameLabel.Padding = new Padding(2, 0, 0, 0);
            ProviderNameLabel.Size = new Size(73, 24);
            ProviderNameLabel.TabIndex = 0;
            ProviderNameLabel.Text = "Proba";
            ProviderNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationPanel
            // 
            RegistrationPanel.BackColor = Color.FromArgb(192, 255, 192);
            RegistrationPanel.BorderStyle = BorderStyle.FixedSingle;
            RegistrationPanel.Controls.Add(LabelInternetSpeed);
            RegistrationPanel.Controls.Add(LabelNumberChannels);
            RegistrationPanel.Controls.Add(LabelPacketPrice);
            RegistrationPanel.Controls.Add(LabelPacketName);
            RegistrationPanel.Controls.Add(LastNameLabel);
            RegistrationPanel.Controls.Add(FirstNameLabel);
            RegistrationPanel.Controls.Add(UsernameLabel);
            RegistrationPanel.Controls.Add(ClientInformationPanel);
            RegistrationPanel.Controls.Add(InternetSpeedLabel);
            RegistrationPanel.Controls.Add(AddPacketLabel);
            RegistrationPanel.Controls.Add(NumberOfChannelsLabel);
            RegistrationPanel.Controls.Add(PacketPriceLabel);
            RegistrationPanel.Controls.Add(PacketNameLabel);
            RegistrationPanel.Controls.Add(RegisterNewPacketLabel);
            RegistrationPanel.Controls.Add(AddClientButton);
            RegistrationPanel.Controls.Add(LastNameTextBox);
            RegistrationPanel.Controls.Add(FirstNameTextBox);
            RegistrationPanel.Controls.Add(UsernameTextBox);
            RegistrationPanel.Controls.Add(RegistrationLabel);
            RegistrationPanel.Dock = DockStyle.Top;
            RegistrationPanel.Location = new Point(0, 33);
            RegistrationPanel.Name = "RegistrationPanel";
            RegistrationPanel.Size = new Size(1121, 219);
            RegistrationPanel.TabIndex = 1;
            // 
            // LabelInternetSpeed
            // 
            LabelInternetSpeed.AutoSize = true;
            LabelInternetSpeed.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelInternetSpeed.Location = new Point(730, 70);
            LabelInternetSpeed.Name = "LabelInternetSpeed";
            LabelInternetSpeed.Size = new Size(98, 21);
            LabelInternetSpeed.TabIndex = 18;
            LabelInternetSpeed.Text = "Net speed";
            // 
            // LabelNumberChannels
            // 
            LabelNumberChannels.AutoSize = true;
            LabelNumberChannels.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelNumberChannels.Location = new Point(647, 71);
            LabelNumberChannels.Name = "LabelNumberChannels";
            LabelNumberChannels.Size = new Size(79, 21);
            LabelNumberChannels.TabIndex = 17;
            LabelNumberChannels.Text = "Num ch";
            // 
            // LabelPacketPrice
            // 
            LabelPacketPrice.AutoSize = true;
            LabelPacketPrice.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelPacketPrice.Location = new Point(498, 71);
            LabelPacketPrice.Name = "LabelPacketPrice";
            LabelPacketPrice.Size = new Size(124, 21);
            LabelPacketPrice.TabIndex = 16;
            LabelPacketPrice.Text = "Packet price";
            // 
            // LabelPacketName
            // 
            LabelPacketName.AutoSize = true;
            LabelPacketName.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelPacketName.Location = new Point(319, 70);
            LabelPacketName.Name = "LabelPacketName";
            LabelPacketName.Size = new Size(128, 21);
            LabelPacketName.TabIndex = 15;
            LabelPacketName.Text = "Packet name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LastNameLabel.Location = new Point(690, 3);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(105, 21);
            LastNameLabel.TabIndex = 14;
            LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FirstNameLabel.Location = new Point(506, 2);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(108, 21);
            FirstNameLabel.TabIndex = 13;
            FirstNameLabel.Text = "First name";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(331, 2);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(101, 21);
            UsernameLabel.TabIndex = 12;
            UsernameLabel.Text = "Username";
            // 
            // ClientInformationPanel
            // 
            ClientInformationPanel.BorderStyle = BorderStyle.FixedSingle;
            ClientInformationPanel.Controls.Add(LastPriceToPayLabel);
            ClientInformationPanel.Controls.Add(PriceToPayValue);
            ClientInformationPanel.Controls.Add(SurnameValueLabel);
            ClientInformationPanel.Controls.Add(NameValueLabel);
            ClientInformationPanel.Controls.Add(LastPriceToPay);
            ClientInformationPanel.Controls.Add(PriceToPayLabel);
            ClientInformationPanel.Controls.Add(SurnameLabel);
            ClientInformationPanel.Controls.Add(LabelName);
            ClientInformationPanel.Controls.Add(ClientInformationLabel);
            ClientInformationPanel.Dock = DockStyle.Bottom;
            ClientInformationPanel.Location = new Point(0, 137);
            ClientInformationPanel.Name = "ClientInformationPanel";
            ClientInformationPanel.Size = new Size(1119, 80);
            ClientInformationPanel.TabIndex = 11;
            ClientInformationPanel.Paint += ClientInformationPanel_Paint;
            // 
            // LastPriceToPayLabel
            // 
            LastPriceToPayLabel.AutoSize = true;
            LastPriceToPayLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LastPriceToPayLabel.Location = new Point(866, 45);
            LastPriceToPayLabel.Name = "LastPriceToPayLabel";
            LastPriceToPayLabel.Size = new Size(0, 21);
            LastPriceToPayLabel.TabIndex = 8;
            LastPriceToPayLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PriceToPayValue
            // 
            PriceToPayValue.AutoSize = true;
            PriceToPayValue.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PriceToPayValue.Location = new Point(674, 45);
            PriceToPayValue.Name = "PriceToPayValue";
            PriceToPayValue.Size = new Size(0, 21);
            PriceToPayValue.TabIndex = 7;
            PriceToPayValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // SurnameValueLabel
            // 
            SurnameValueLabel.AutoSize = true;
            SurnameValueLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SurnameValueLabel.Location = new Point(512, 45);
            SurnameValueLabel.Name = "SurnameValueLabel";
            SurnameValueLabel.Size = new Size(0, 21);
            SurnameValueLabel.TabIndex = 6;
            SurnameValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameValueLabel
            // 
            NameValueLabel.AutoSize = true;
            NameValueLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NameValueLabel.Location = new Point(348, 46);
            NameValueLabel.Name = "NameValueLabel";
            NameValueLabel.Size = new Size(0, 21);
            NameValueLabel.TabIndex = 5;
            NameValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LastPriceToPay
            // 
            LastPriceToPay.AutoSize = true;
            LastPriceToPay.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LastPriceToPay.Location = new Point(854, 12);
            LastPriceToPay.Name = "LastPriceToPay";
            LastPriceToPay.Size = new Size(163, 21);
            LastPriceToPay.TabIndex = 4;
            LastPriceToPay.Text = "Last price to pay";
            // 
            // PriceToPayLabel
            // 
            PriceToPayLabel.AutoSize = true;
            PriceToPayLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PriceToPayLabel.Location = new Point(634, 12);
            PriceToPayLabel.Name = "PriceToPayLabel";
            PriceToPayLabel.Size = new Size(195, 21);
            PriceToPayLabel.TabIndex = 3;
            PriceToPayLabel.Text = "Current price to pay";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SurnameLabel.Location = new Point(508, 11);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(93, 21);
            SurnameLabel.TabIndex = 2;
            SurnameLabel.Text = "Surname";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelName.Location = new Point(347, 9);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(61, 21);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name";
            // 
            // ClientInformationLabel
            // 
            ClientInformationLabel.AutoSize = true;
            ClientInformationLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ClientInformationLabel.Location = new Point(12, 27);
            ClientInformationLabel.Name = "ClientInformationLabel";
            ClientInformationLabel.Size = new Size(220, 24);
            ClientInformationLabel.TabIndex = 0;
            ClientInformationLabel.Text = "Client informations";
            // 
            // InternetSpeedLabel
            // 
            InternetSpeedLabel.Location = new Point(733, 98);
            InternetSpeedLabel.Multiline = true;
            InternetSpeedLabel.Name = "InternetSpeedLabel";
            InternetSpeedLabel.Size = new Size(91, 27);
            InternetSpeedLabel.TabIndex = 10;
            // 
            // AddPacketLabel
            // 
            AddPacketLabel.BackColor = Color.Silver;
            AddPacketLabel.Location = new Point(891, 90);
            AddPacketLabel.Name = "AddPacketLabel";
            AddPacketLabel.Size = new Size(126, 42);
            AddPacketLabel.TabIndex = 9;
            AddPacketLabel.Text = "Add";
            AddPacketLabel.UseVisualStyleBackColor = false;
            AddPacketLabel.Click += button1_Click;
            // 
            // NumberOfChannelsLabel
            // 
            NumberOfChannelsLabel.Location = new Point(655, 98);
            NumberOfChannelsLabel.Multiline = true;
            NumberOfChannelsLabel.Name = "NumberOfChannelsLabel";
            NumberOfChannelsLabel.Size = new Size(71, 27);
            NumberOfChannelsLabel.TabIndex = 8;
            NumberOfChannelsLabel.TextChanged += NumberOfChannelsLabel_TextChanged;
            // 
            // PacketPriceLabel
            // 
            PacketPriceLabel.Location = new Point(476, 98);
            PacketPriceLabel.Name = "PacketPriceLabel";
            PacketPriceLabel.Size = new Size(173, 27);
            PacketPriceLabel.TabIndex = 7;
            // 
            // PacketNameLabel
            // 
            PacketNameLabel.Location = new Point(297, 98);
            PacketNameLabel.Name = "PacketNameLabel";
            PacketNameLabel.Size = new Size(173, 27);
            PacketNameLabel.TabIndex = 6;
            // 
            // RegisterNewPacketLabel
            // 
            RegisterNewPacketLabel.AutoSize = true;
            RegisterNewPacketLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegisterNewPacketLabel.Location = new Point(10, 99);
            RegisterNewPacketLabel.Name = "RegisterNewPacketLabel";
            RegisterNewPacketLabel.Padding = new Padding(5, 0, 0, 0);
            RegisterNewPacketLabel.Size = new Size(185, 24);
            RegisterNewPacketLabel.TabIndex = 5;
            RegisterNewPacketLabel.Text = "Add new packet";
            // 
            // AddClientButton
            // 
            AddClientButton.BackColor = Color.Silver;
            AddClientButton.Location = new Point(891, 20);
            AddClientButton.Name = "AddClientButton";
            AddClientButton.Size = new Size(126, 42);
            AddClientButton.TabIndex = 4;
            AddClientButton.Text = "Register";
            AddClientButton.UseVisualStyleBackColor = false;
            AddClientButton.Click += AddClientButton_Click;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(655, 28);
            LastNameTextBox.Multiline = true;
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(173, 27);
            LastNameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(476, 28);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(173, 27);
            FirstNameTextBox.TabIndex = 2;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(297, 28);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(173, 27);
            UsernameTextBox.TabIndex = 1;
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegistrationLabel.Location = new Point(10, 29);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Padding = new Padding(5, 0, 0, 0);
            RegistrationLabel.Size = new Size(219, 24);
            RegistrationLabel.TabIndex = 0;
            RegistrationLabel.Text = "Register new client";
            RegistrationLabel.Click += RegistrationLabel_Click;
            // 
            // ClientPanel
            // 
            ClientPanel.BackColor = Color.FromArgb(192, 255, 192);
            ClientPanel.Controls.Add(ListOfClientsPanel);
            ClientPanel.Controls.Add(ClientLabel);
            ClientPanel.Dock = DockStyle.Left;
            ClientPanel.Location = new Point(0, 252);
            ClientPanel.Name = "ClientPanel";
            ClientPanel.Size = new Size(230, 400);
            ClientPanel.TabIndex = 2;
            // 
            // ListOfClientsPanel
            // 
            ListOfClientsPanel.AutoScroll = true;
            ListOfClientsPanel.Location = new Point(12, 47);
            ListOfClientsPanel.Name = "ListOfClientsPanel";
            ListOfClientsPanel.Size = new Size(184, 316);
            ListOfClientsPanel.TabIndex = 1;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ClientLabel.Location = new Point(30, 3);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Padding = new Padding(5, 0, 0, 0);
            ClientLabel.Size = new Size(123, 32);
            ClientLabel.TabIndex = 0;
            ClientLabel.Text = "Clients";
            ClientLabel.Click += ClientLabel_Click;
            // 
            // TvPacketPanel
            // 
            TvPacketPanel.Controls.Add(ListOfTvPacketPanel);
            TvPacketPanel.Controls.Add(TvPacketLabel);
            TvPacketPanel.Dock = DockStyle.Left;
            TvPacketPanel.Location = new Point(230, 252);
            TvPacketPanel.Name = "TvPacketPanel";
            TvPacketPanel.Size = new Size(305, 400);
            TvPacketPanel.TabIndex = 3;
            // 
            // ListOfTvPacketPanel
            // 
            ListOfTvPacketPanel.AutoScroll = true;
            ListOfTvPacketPanel.Location = new Point(26, 47);
            ListOfTvPacketPanel.Name = "ListOfTvPacketPanel";
            ListOfTvPacketPanel.Size = new Size(258, 316);
            ListOfTvPacketPanel.TabIndex = 2;
            // 
            // TvPacketLabel
            // 
            TvPacketLabel.AutoSize = true;
            TvPacketLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TvPacketLabel.Location = new Point(76, 14);
            TvPacketLabel.Name = "TvPacketLabel";
            TvPacketLabel.Size = new Size(112, 21);
            TvPacketLabel.TabIndex = 0;
            TvPacketLabel.Text = "TV Packets";
            // 
            // InternetPacketPanel
            // 
            InternetPacketPanel.Controls.Add(ListOfInternetPacketPanel);
            InternetPacketPanel.Controls.Add(InternetPacketLabel);
            InternetPacketPanel.Dock = DockStyle.Left;
            InternetPacketPanel.Location = new Point(535, 252);
            InternetPacketPanel.Name = "InternetPacketPanel";
            InternetPacketPanel.Size = new Size(302, 400);
            InternetPacketPanel.TabIndex = 4;
            InternetPacketPanel.Paint += InternetPacketPanel_Paint;
            // 
            // ListOfInternetPacketPanel
            // 
            ListOfInternetPacketPanel.AutoScroll = true;
            ListOfInternetPacketPanel.Location = new Point(20, 50);
            ListOfInternetPacketPanel.Name = "ListOfInternetPacketPanel";
            ListOfInternetPacketPanel.Size = new Size(258, 316);
            ListOfInternetPacketPanel.TabIndex = 3;
            // 
            // InternetPacketLabel
            // 
            InternetPacketLabel.AutoSize = true;
            InternetPacketLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InternetPacketLabel.Location = new Point(51, 14);
            InternetPacketLabel.Name = "InternetPacketLabel";
            InternetPacketLabel.Size = new Size(160, 21);
            InternetPacketLabel.TabIndex = 0;
            InternetPacketLabel.Text = "Internet Packets";
            // 
            // CombinedPacketPanel
            // 
            CombinedPacketPanel.Controls.Add(ListOfCombinedPacketPanel);
            CombinedPacketPanel.Controls.Add(CombinePacketLabel);
            CombinedPacketPanel.Dock = DockStyle.Left;
            CombinedPacketPanel.Location = new Point(837, 252);
            CombinedPacketPanel.Name = "CombinedPacketPanel";
            CombinedPacketPanel.Size = new Size(284, 400);
            CombinedPacketPanel.TabIndex = 5;
            // 
            // ListOfCombinedPacketPanel
            // 
            ListOfCombinedPacketPanel.AutoScroll = true;
            ListOfCombinedPacketPanel.Location = new Point(16, 47);
            ListOfCombinedPacketPanel.Name = "ListOfCombinedPacketPanel";
            ListOfCombinedPacketPanel.Size = new Size(258, 316);
            ListOfCombinedPacketPanel.TabIndex = 4;
            // 
            // CombinePacketLabel
            // 
            CombinePacketLabel.AutoSize = true;
            CombinePacketLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CombinePacketLabel.Location = new Point(39, 14);
            CombinePacketLabel.Name = "CombinePacketLabel";
            CombinePacketLabel.Size = new Size(175, 21);
            CombinePacketLabel.TabIndex = 0;
            CombinePacketLabel.Text = "Combined Packets";
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 652);
            Controls.Add(CombinedPacketPanel);
            Controls.Add(InternetPacketPanel);
            Controls.Add(TvPacketPanel);
            Controls.Add(ClientPanel);
            Controls.Add(RegistrationPanel);
            Controls.Add(ProviderName);
            Name = "ApplicationForm";
            Load += ApplicationForm_Load;
            ProviderName.ResumeLayout(false);
            ProviderName.PerformLayout();
            RegistrationPanel.ResumeLayout(false);
            RegistrationPanel.PerformLayout();
            ClientInformationPanel.ResumeLayout(false);
            ClientInformationPanel.PerformLayout();
            ClientPanel.ResumeLayout(false);
            ClientPanel.PerformLayout();
            TvPacketPanel.ResumeLayout(false);
            TvPacketPanel.PerformLayout();
            InternetPacketPanel.ResumeLayout(false);
            InternetPacketPanel.PerformLayout();
            CombinedPacketPanel.ResumeLayout(false);
            CombinedPacketPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ProviderName;
        private Label ProviderNameLabel;
        private Panel RegistrationPanel;
        private Label RegistrationLabel;
        private TextBox UsernameTextBox;
        private Button AddClientButton;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Panel ClientPanel;
        private Label ClientLabel;
        private FlowLayoutPanel ListOfClientsPanel;
        private Panel TvPacketPanel;
        private Label TvPacketLabel;
        private Panel InternetPacketPanel;
        private Label InternetPacketLabel;
        private Panel CombinedPacketPanel;
        private Label CombinePacketLabel;
        private FlowLayoutPanel ListOfTvPacketPanel;
        private FlowLayoutPanel ListOfInternetPacketPanel;
        private FlowLayoutPanel ListOfCombinedPacketPanel;
        private TextBox InternetSpeedLabel;
        private Button AddPacketLabel;
        private TextBox NumberOfChannelsLabel;
        private TextBox PacketPriceLabel;
        private TextBox PacketNameLabel;
        private Label RegisterNewPacketLabel;
        private Panel ClientInformationPanel;
        private Label ClientInformationLabel;
        private Label PriceToPayLabel;
        private Label SurnameLabel;
        private Label LabelName;
        private Label SurnameValueLabel;
        private Label NameValueLabel;
        private Label LastPriceToPay;
        private Label LastPriceToPayLabel;
        private Label PriceToPayValue;
        private Label LabelPacketName;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label UsernameLabel;
        private Label LabelInternetSpeed;
        private Label LabelNumberChannels;
        private Label LabelPacketPrice;
    }
}