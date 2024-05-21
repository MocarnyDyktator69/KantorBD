namespace KantorBD
{
    partial class TransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistory));
            label2 = new Label();
            dataGridViewTransactions = new DataGridView();
            MenuPanel = new Panel();
            buttonMoneyTransfer = new PictureBox();
            buttonHome = new PictureBox();
            buttonCurrencyExchange = new PictureBox();
            buttonSettings = new PictureBox();
            buttonWallet = new PictureBox();
            buttonHistory = new PictureBox();
            buttonLogOut = new PictureBox();
            labelClose = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
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
            label2.BackColor = Color.FromArgb(36, 26, 82);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 27.5F);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(364, 177);
            label2.Name = "label2";
            label2.Size = new Size(383, 60);
            label2.TabIndex = 33;
            label2.Text = "Transaction History";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.BackgroundColor = Color.FromArgb(5, 5, 50);
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.GridColor = Color.FromArgb(255, 193, 37);
            dataGridViewTransactions.Location = new Point(12, 240);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.Size = new Size(1040, 350);
            dataGridViewTransactions.TabIndex = 35;
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
            MenuPanel.TabIndex = 109;
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
            labelClose.TabIndex = 108;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            Controls.Add(dataGridViewTransactions);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
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

        private void pictureBoxTransactionHistory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label2;
        private DataGridView dataGridViewTransactions;
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