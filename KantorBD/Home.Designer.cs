namespace KantorBD
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            rateBox = new ComboBox();
            labelPLN = new Label();
            labelGBP = new Label();
            labelUSD = new Label();
            labelEUR = new Label();
            pictureBox30 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox27 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MenuPanel = new Panel();
            buttonMoneyTransfer = new PictureBox();
            buttonHome = new PictureBox();
            buttonCurrencyExchange = new PictureBox();
            buttonSettings = new PictureBox();
            buttonWallet = new PictureBox();
            buttonHistory = new PictureBox();
            buttonLogOut = new PictureBox();
            labelClose = new Label();
            buttonSearch = new Button();
            listViewNotifi = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMoneyTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonCurrencyExchange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonWallet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonLogOut).BeginInit();
            SuspendLayout();
            // 
            // rateBox
            // 
            rateBox.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rateBox.ForeColor = Color.FromArgb(255, 193, 37);
            rateBox.FormattingEnabled = true;
            rateBox.Items.AddRange(new object[] { "EUR", "USD", "GBP", "PLN" });
            rateBox.Location = new Point(177, 382);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(200, 75);
            rateBox.TabIndex = 101;
            rateBox.SelectedIndexChanged += rateBox_SelectedIndexChanged;
            // 
            // labelPLN
            // 
            labelPLN.BackColor = Color.White;
            labelPLN.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPLN.ForeColor = Color.FromArgb(255, 193, 37);
            labelPLN.Location = new Point(177, 597);
            labelPLN.Name = "labelPLN";
            labelPLN.Size = new Size(200, 75);
            labelPLN.TabIndex = 100;
            labelPLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGBP
            // 
            labelGBP.BackColor = Color.White;
            labelGBP.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelGBP.ForeColor = Color.FromArgb(255, 193, 37);
            labelGBP.Location = new Point(707, 597);
            labelGBP.Name = "labelGBP";
            labelGBP.Size = new Size(200, 75);
            labelGBP.TabIndex = 99;
            labelGBP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUSD
            // 
            labelUSD.BackColor = Color.White;
            labelUSD.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUSD.ForeColor = Color.FromArgb(255, 193, 37);
            labelUSD.Location = new Point(177, 498);
            labelUSD.Name = "labelUSD";
            labelUSD.Size = new Size(200, 75);
            labelUSD.TabIndex = 98;
            labelUSD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEUR
            // 
            labelEUR.BackColor = Color.White;
            labelEUR.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelEUR.ForeColor = Color.FromArgb(255, 193, 37);
            labelEUR.Location = new Point(707, 496);
            labelEUR.Name = "labelEUR";
            labelEUR.Size = new Size(200, 75);
            labelEUR.TabIndex = 97;
            labelEUR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox30
            // 
            pictureBox30.Image = (Image)resources.GetObject("pictureBox30.Image");
            pictureBox30.Location = new Point(405, 498);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(51, 73);
            pictureBox30.TabIndex = 96;
            pictureBox30.TabStop = false;
            // 
            // pictureBox29
            // 
            pictureBox29.Image = (Image)resources.GetObject("pictureBox29.Image");
            pictureBox29.Location = new Point(935, 597);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(60, 72);
            pictureBox29.TabIndex = 95;
            pictureBox29.TabStop = false;
            // 
            // pictureBox28
            // 
            pictureBox28.Image = (Image)resources.GetObject("pictureBox28.Image");
            pictureBox28.Location = new Point(935, 496);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(69, 75);
            pictureBox28.TabIndex = 94;
            pictureBox28.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.Image = (Image)resources.GetObject("pictureBox27.Image");
            pictureBox27.Location = new Point(405, 597);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(162, 65);
            pictureBox27.TabIndex = 93;
            pictureBox27.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(36, 26, 82);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(401, 394);
            label3.Name = "label3";
            label3.Size = new Size(293, 56);
            label3.TabIndex = 92;
            label3.Text = "Exchange rate";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 26, 82);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(598, 514);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 102;
            label2.Text = "EURO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(36, 26, 82);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(255, 193, 37);
            label4.Location = new Point(87, 515);
            label4.Name = "label4";
            label4.Size = new Size(75, 38);
            label4.TabIndex = 103;
            label4.Text = "USD";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(36, 26, 82);
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(617, 613);
            label5.Name = "label5";
            label5.Size = new Size(66, 38);
            label5.TabIndex = 104;
            label5.Text = "GBP";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(36, 26, 82);
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(255, 193, 37);
            label6.Location = new Point(5, 615);
            label6.Name = "label6";
            label6.Size = new Size(157, 38);
            label6.TabIndex = 105;
            label6.Text = "Polski złoty";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(16, 9, 48);
            MenuPanel.Controls.Add(buttonMoneyTransfer);
            MenuPanel.Controls.Add(buttonHome);
            MenuPanel.Controls.Add(buttonCurrencyExchange);
            MenuPanel.Controls.Add(buttonSettings);
            MenuPanel.Controls.Add(buttonWallet);
            MenuPanel.Controls.Add(buttonHistory);
            MenuPanel.Controls.Add(buttonLogOut);
            MenuPanel.Location = new Point(-2, 64);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1064, 110);
            MenuPanel.TabIndex = 107;
            // 
            // buttonMoneyTransfer
            // 
            buttonMoneyTransfer.Cursor = Cursors.Hand;
            buttonMoneyTransfer.Image = (Image)resources.GetObject("buttonMoneyTransfer.Image");
            buttonMoneyTransfer.Location = new Point(644, 20);
            buttonMoneyTransfer.Margin = new Padding(5);
            buttonMoneyTransfer.Name = "buttonMoneyTransfer";
            buttonMoneyTransfer.Size = new Size(65, 65);
            buttonMoneyTransfer.TabIndex = 18;
            buttonMoneyTransfer.TabStop = false;
            buttonMoneyTransfer.Click += buttonMoneyTransfer_Click;
            // 
            // buttonHome
            // 
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.Location = new Point(344, 20);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(65, 65);
            buttonHome.TabIndex = 17;
            buttonHome.TabStop = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCurrencyExchange
            // 
            buttonCurrencyExchange.Cursor = Cursors.Hand;
            buttonCurrencyExchange.Image = (Image)resources.GetObject("buttonCurrencyExchange.Image");
            buttonCurrencyExchange.Location = new Point(544, 20);
            buttonCurrencyExchange.Margin = new Padding(5);
            buttonCurrencyExchange.Name = "buttonCurrencyExchange";
            buttonCurrencyExchange.Size = new Size(65, 65);
            buttonCurrencyExchange.TabIndex = 17;
            buttonCurrencyExchange.TabStop = false;
            buttonCurrencyExchange.Click += buttonCurrencyExchange_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.Image = (Image)resources.GetObject("buttonSettings.Image");
            buttonSettings.Location = new Point(844, 20);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(65, 65);
            buttonSettings.TabIndex = 17;
            buttonSettings.TabStop = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonWallet
            // 
            buttonWallet.Cursor = Cursors.Hand;
            buttonWallet.Image = (Image)resources.GetObject("buttonWallet.Image");
            buttonWallet.Location = new Point(444, 20);
            buttonWallet.Margin = new Padding(5);
            buttonWallet.Name = "buttonWallet";
            buttonWallet.Size = new Size(65, 65);
            buttonWallet.TabIndex = 2;
            buttonWallet.TabStop = false;
            buttonWallet.Click += buttonWallet_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.Cursor = Cursors.Hand;
            buttonHistory.Image = (Image)resources.GetObject("buttonHistory.Image");
            buttonHistory.Location = new Point(744, 20);
            buttonHistory.Margin = new Padding(5);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(65, 65);
            buttonHistory.TabIndex = 1;
            buttonHistory.TabStop = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(16, 9, 48);
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageLocation = "";
            buttonLogOut.Location = new Point(944, 20);
            buttonLogOut.Margin = new Padding(5);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(65, 65);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.TabStop = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Comic Sans MS", 27.75F);
            labelClose.ForeColor = Color.FromArgb(255, 193, 37);
            labelClose.Location = new Point(1001, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(49, 52);
            labelClose.TabIndex = 106;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(16, 9, 48);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSearch.ForeColor = Color.FromArgb(255, 193, 37);
            buttonSearch.Location = new Point(707, 385);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(200, 72);
            buttonSearch.TabIndex = 108;
            buttonSearch.Text = "Historia kursów";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listViewNotifi
            // 
            listViewNotifi = new System.Windows.Forms.ListView();
            listViewNotifi.Location = new Point(22, 190);
            listViewNotifi.Name = "listViewNotifi";
            listViewNotifi.Size = new Size(1020, 170);
            listViewNotifi.TabIndex = 109;
            listViewNotifi.UseCompatibleStateImageBehavior = false;
            listViewNotifi.TabIndex = 59;
            listViewNotifi.UseCompatibleStateImageBehavior = false;
            listViewNotifi.View = System.Windows.Forms.View.Details;
            listViewNotifi.Columns.Add("Title", 200, HorizontalAlignment.Left);
            listViewNotifi.Columns.Add("Content", 800, HorizontalAlignment.Left);
            Controls.Add(listViewNotifi);
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(listViewNotifi);
            Controls.Add(buttonSearch);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(rateBox);
            Controls.Add(labelPLN);
            Controls.Add(labelGBP);
            Controls.Add(labelUSD);
            Controls.Add(labelEUR);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox27);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMoneyTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonCurrencyExchange).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonWallet).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonLogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHome;
        protected ComboBox rateBox;
        private Label labelPLN;
        private Label labelGBP;
        private Label labelUSD;
        private Label labelEUR;
        private PictureBox pictureBox30;
        private PictureBox pictureBox29;
        private PictureBox pictureBox28;
        private PictureBox pictureBox27;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel MenuPanel;
        private PictureBox buttonHome;
        private PictureBox buttonCurrencyExchange;
        private PictureBox buttonSettings;
        private PictureBox buttonWallet;
        private PictureBox buttonHistory;
        private PictureBox buttonLogOut;
        private Label labelClose;
        private PictureBox buttonMoneyTransfer;
        private Button buttonSearch;
        private ListView listViewNotifi;
    }
}