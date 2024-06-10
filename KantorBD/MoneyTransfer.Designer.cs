
namespace KantorBD
{
    partial class MoneyTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyTransfer));
            txtCreditCardNumber = new TextBox();
            label2 = new Label();
            back_button = new Button();
            label3 = new Label();
            textBoxPassword = new TextBox();
            buttonTransfer = new Button();
            label4 = new Label();
            textBoxCVV = new TextBox();
            label5 = new Label();
            textBoxAmount = new TextBox();
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
            // txtCreditCardNumber
            // 
            txtCreditCardNumber.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtCreditCardNumber.Location = new Point(489, 201);
            txtCreditCardNumber.MaxLength = 16;
            txtCreditCardNumber.Multiline = true;
            txtCreditCardNumber.Name = "txtCreditCardNumber";
            txtCreditCardNumber.Size = new Size(413, 38);
            txtCreditCardNumber.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 26, 82);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(64, 201);
            label2.Name = "label2";
            label2.Size = new Size(404, 38);
            label2.TabIndex = 84;
            label2.Text = "Enter your credit card number";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 609);
            back_button.Name = "back_button";
            back_button.Size = new Size(252, 44);
            back_button.TabIndex = 85;
            back_button.Text = "back";
            back_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(36, 26, 82);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(228, 359);
            label3.Name = "label3";
            label3.Size = new Size(240, 38);
            label3.TabIndex = 86;
            label3.Text = "Confirm password";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxPassword.Location = new Point(489, 359);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(413, 38);
            textBoxPassword.TabIndex = 87;
            // 
            // buttonTransfer
            // 
            buttonTransfer.ForeColor = Color.FromArgb(17, 176, 33);
            buttonTransfer.Location = new Point(773, 609);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(252, 44);
            buttonTransfer.TabIndex = 88;
            buttonTransfer.Text = "Accept";
            buttonTransfer.UseVisualStyleBackColor = true;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(36, 26, 82);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(255, 193, 37);
            label4.Location = new Point(233, 406);
            label4.Name = "label4";
            label4.Size = new Size(644, 200);
            label4.TabIndex = 89;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBoxCVV
            // 
            textBoxCVV.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxCVV.Location = new Point(917, 201);
            textBoxCVV.MaxLength = 3;
            textBoxCVV.Multiline = true;
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.Size = new Size(72, 38);
            textBoxCVV.TabIndex = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(36, 26, 82);
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(233, 273);
            label5.Name = "label5";
            label5.Size = new Size(235, 38);
            label5.TabIndex = 91;
            label5.Text = "Amount of money";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxAmount.Location = new Point(489, 273);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(413, 38);
            textBoxAmount.TabIndex = 92;
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
            // MoneyTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            Controls.Add(textBoxAmount);
            Controls.Add(label5);
            Controls.Add(textBoxCVV);
            Controls.Add(label4);
            Controls.Add(buttonTransfer);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(back_button);
            Controls.Add(label2);
            Controls.Add(txtCreditCardNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoneyTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += MoneyTransfer_Load;
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
        private TextBox txtCreditCardNumber;
        private Label label2;
        private Button back_button;
        private Label label3;
        private TextBox textBoxPassword;
        private Button buttonTransfer;
        private Label label4;
        private TextBox textBoxCVV;
        private Label label5;
        private TextBox textBoxAmount;
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