namespace KantorBD
{
    partial class CurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyExchange));
            label2 = new Label();
            pictureBox12 = new PictureBox();
            label3 = new Label();
            pictureBox13 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox30 = new PictureBox();
            FromCurrencyBox = new ComboBox();
            ToCurrencyBox = new ComboBox();
            AmountToConvertBox = new TextBox();
            ExchangeButton = new Button();
            ConvertedAmountDisplay = new Label();
            labelEUR = new Label();
            labelUSD = new Label();
            labelGBP = new Label();
            labelPLN = new Label();
            rateBox = new ComboBox();
            MenuPanel = new Panel();
            buttonMoneyTransfer = new PictureBox();
            buttonHome = new PictureBox();
            buttonCurrencyExchange = new PictureBox();
            buttonSettings = new PictureBox();
            buttonWallet = new PictureBox();
            buttonHistory = new PictureBox();
            buttonLogOut = new PictureBox();
            labelClose = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 26, 82);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(21, 194);
            label2.Name = "label2";
            label2.Size = new Size(388, 56);
            label2.TabIndex = 17;
            label2.Text = "Currency calculator";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(248, 396);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(46, 39);
            pictureBox12.TabIndex = 19;
            pictureBox12.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(36, 26, 82);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(508, 194);
            label3.Name = "label3";
            label3.Size = new Size(293, 56);
            label3.TabIndex = 22;
            label3.Text = "Exchange rate";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(291, 396);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(42, 39);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.Image = (Image)resources.GetObject("pictureBox27.Image");
            pictureBox27.Location = new Point(639, 563);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(162, 65);
            pictureBox27.TabIndex = 38;
            pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            pictureBox28.Image = (Image)resources.GetObject("pictureBox28.Image");
            pictureBox28.Location = new Point(713, 278);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(69, 75);
            pictureBox28.TabIndex = 39;
            pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            pictureBox29.Image = (Image)resources.GetObject("pictureBox29.Image");
            pictureBox29.Location = new Point(722, 468);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(60, 72);
            pictureBox29.TabIndex = 40;
            pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            pictureBox30.Image = (Image)resources.GetObject("pictureBox30.Image");
            pictureBox30.Location = new Point(722, 373);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(51, 73);
            pictureBox30.TabIndex = 41;
            pictureBox30.TabStop = false;
            // 
            // FromCurrencyBox
            // 
            FromCurrencyBox.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FromCurrencyBox.ForeColor = Color.FromArgb(255, 193, 37);
            FromCurrencyBox.FormattingEnabled = true;
            FromCurrencyBox.Items.AddRange(new object[] { "EUR", "USD", "GBP", "PLN" });
            FromCurrencyBox.Location = new Point(368, 291);
            FromCurrencyBox.Name = "FromCurrencyBox";
            FromCurrencyBox.Size = new Size(207, 75);
            FromCurrencyBox.TabIndex = 49;
            // 
            // ToCurrencyBox
            // 
            ToCurrencyBox.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ToCurrencyBox.ForeColor = Color.FromArgb(255, 193, 37);
            ToCurrencyBox.FormattingEnabled = true;
            ToCurrencyBox.Items.AddRange(new object[] { "EUR", "USD", "GBP", "PLN" });
            ToCurrencyBox.Location = new Point(368, 466);
            ToCurrencyBox.Name = "ToCurrencyBox";
            ToCurrencyBox.Size = new Size(207, 75);
            ToCurrencyBox.TabIndex = 49;
            // 
            // AmountToConvertBox
            // 
            AmountToConvertBox.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AmountToConvertBox.ForeColor = Color.FromArgb(255, 193, 37);
            AmountToConvertBox.Location = new Point(21, 292);
            AmountToConvertBox.Name = "AmountToConvertBox";
            AmountToConvertBox.Size = new Size(345, 74);
            AmountToConvertBox.TabIndex = 51;
            AmountToConvertBox.Text = "0";
            AmountToConvertBox.TextChanged += AmountToConvertBox_TextChanged;
            // 
            // ExchangeButton
            // 
            ExchangeButton.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExchangeButton.ForeColor = Color.FromArgb(255, 193, 37);
            ExchangeButton.Location = new Point(115, 569);
            ExchangeButton.Name = "ExchangeButton";
            ExchangeButton.Size = new Size(350, 100);
            ExchangeButton.TabIndex = 53;
            ExchangeButton.Text = "Exchange";
            ExchangeButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExchangeButton.UseVisualStyleBackColor = true;
            ExchangeButton.Click += ExchangeButton_Click;
            // 
            // ConvertedAmountDisplay
            // 
            ConvertedAmountDisplay.BackColor = Color.White;
            ConvertedAmountDisplay.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ConvertedAmountDisplay.ForeColor = Color.FromArgb(255, 193, 37);
            ConvertedAmountDisplay.Location = new Point(21, 467);
            ConvertedAmountDisplay.Name = "ConvertedAmountDisplay";
            ConvertedAmountDisplay.Size = new Size(345, 74);
            ConvertedAmountDisplay.TabIndex = 54;
            ConvertedAmountDisplay.Text = "0";
            // 
            // labelEUR
            // 
            labelEUR.BackColor = Color.White;
            labelEUR.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelEUR.ForeColor = Color.FromArgb(255, 193, 37);
            labelEUR.Location = new Point(824, 278);
            labelEUR.Name = "labelEUR";
            labelEUR.Size = new Size(200, 75);
            labelEUR.TabIndex = 55;
            labelEUR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUSD
            // 
            labelUSD.BackColor = Color.White;
            labelUSD.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUSD.ForeColor = Color.FromArgb(255, 193, 37);
            labelUSD.Location = new Point(824, 373);
            labelUSD.Name = "labelUSD";
            labelUSD.Size = new Size(200, 75);
            labelUSD.TabIndex = 55;
            labelUSD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGBP
            // 
            labelGBP.BackColor = Color.White;
            labelGBP.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelGBP.ForeColor = Color.FromArgb(255, 193, 37);
            labelGBP.Location = new Point(824, 468);
            labelGBP.Name = "labelGBP";
            labelGBP.Size = new Size(200, 75);
            labelGBP.TabIndex = 55;
            labelGBP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPLN
            // 
            labelPLN.BackColor = Color.White;
            labelPLN.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPLN.ForeColor = Color.FromArgb(255, 193, 37);
            labelPLN.Location = new Point(824, 563);
            labelPLN.Name = "labelPLN";
            labelPLN.Size = new Size(200, 75);
            labelPLN.TabIndex = 55;
            labelPLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rateBox
            // 
            rateBox.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rateBox.ForeColor = Color.FromArgb(255, 193, 37);
            rateBox.FormattingEnabled = true;
            rateBox.Items.AddRange(new object[] { "EUR", "USD", "GBP", "PLN" });
            rateBox.Location = new Point(824, 183);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(200, 75);
            rateBox.TabIndex = 56;
            rateBox.SelectedIndexChanged += rateBox_SelectedIndexChanged;
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
            MenuPanel.Location = new Point(0, 64);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1064, 110);
            MenuPanel.TabIndex = 115;
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
            labelClose.Location = new Point(1003, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(49, 52);
            labelClose.TabIndex = 114;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // CurrencyExchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            Controls.Add(rateBox);
            Controls.Add(labelPLN);
            Controls.Add(labelGBP);
            Controls.Add(labelUSD);
            Controls.Add(labelEUR);
            Controls.Add(ConvertedAmountDisplay);
            Controls.Add(ExchangeButton);
            Controls.Add(AmountToConvertBox);
            Controls.Add(ToCurrencyBox);
            Controls.Add(FromCurrencyBox);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox13);
            Controls.Add(label3);
            Controls.Add(pictureBox12);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CurrencyExchange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CurrencyExchange_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
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
        private Label label2;
        private PictureBox pictureBox12;
        private Label label3;
        private PictureBox pictureBox13;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private ComboBox FromCurrencyBox;
        private ComboBox ToCurrencyBox;
        private TextBox AmountToConvertBox;
        private Button ExchangeButton;
        private Label ConvertedAmountDisplay;
        private Label labelEUR;
        private Label labelUSD;
        private Label labelGBP;
        private Label labelPLN;
        protected ComboBox rateBox;
        private Panel MenuPanel;
        private PictureBox buttonMoneyTransfer;
        private PictureBox buttonHome;
        private PictureBox buttonCurrencyExchange;
        private PictureBox buttonSettings;
        private PictureBox buttonWallet;
        private PictureBox buttonHistory;
        private PictureBox buttonLogOut;
        private Label labelClose;
    }
}