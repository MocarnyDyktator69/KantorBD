namespace KantorBD
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            labelName = new Label();
            labelSurname = new Label();
            labelMail = new Label();
            labelCardNumber = new Label();
            editDataButton = new Button();
            MenuPanel = new Panel();
            buttonMoneyTransfer = new PictureBox();
            buttonHome = new PictureBox();
            buttonCurrencyExchange = new PictureBox();
            buttonSettings = new PictureBox();
            buttonWallet = new PictureBox();
            buttonHistory = new PictureBox();
            buttonLogOut = new PictureBox();
            labelClose = new Label();
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
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(36, 26, 82);
            labelName.Cursor = Cursors.Hand;
            labelName.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelName.ForeColor = Color.FromArgb(255, 193, 37);
            labelName.Location = new Point(12, 177);
            labelName.Name = "labelName";
            labelName.Size = new Size(153, 56);
            labelName.TabIndex = 92;
            labelName.Text = "Name: ";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.BackColor = Color.FromArgb(36, 26, 82);
            labelSurname.Cursor = Cursors.Hand;
            labelSurname.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSurname.ForeColor = Color.FromArgb(255, 193, 37);
            labelSurname.Location = new Point(12, 257);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(210, 56);
            labelSurname.TabIndex = 93;
            labelSurname.Text = "Surname: ";
            labelSurname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.FromArgb(36, 26, 82);
            labelMail.Cursor = Cursors.Hand;
            labelMail.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMail.ForeColor = Color.FromArgb(255, 193, 37);
            labelMail.Location = new Point(12, 337);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(163, 56);
            labelMail.TabIndex = 94;
            labelMail.Text = "E-mail: ";
            labelMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.BackColor = Color.FromArgb(36, 26, 82);
            labelCardNumber.Cursor = Cursors.Hand;
            labelCardNumber.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCardNumber.ForeColor = Color.FromArgb(255, 193, 37);
            labelCardNumber.Location = new Point(12, 417);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(413, 56);
            labelCardNumber.TabIndex = 95;
            labelCardNumber.Text = "Credit card number: ";
            labelCardNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editDataButton
            // 
            editDataButton.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            editDataButton.ForeColor = Color.FromArgb(255, 193, 37);
            editDataButton.Location = new Point(365, 520);
            editDataButton.Name = "editDataButton";
            editDataButton.Size = new Size(350, 100);
            editDataButton.TabIndex = 96;
            editDataButton.Text = "Edit Data";
            editDataButton.TextImageRelation = TextImageRelation.ImageAboveText;
            editDataButton.UseVisualStyleBackColor = true;
            editDataButton.Click += editDataButton_Click;
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
            MenuPanel.TabIndex = 111;
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
            labelClose.TabIndex = 110;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            Controls.Add(editDataButton);
            Controls.Add(labelCardNumber);
            Controls.Add(labelMail);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAccount";
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
        private Label labelName;
        private Label labelSurname;
        private Label labelMail;
        private Label labelCardNumber;
        private Button editDataButton;
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