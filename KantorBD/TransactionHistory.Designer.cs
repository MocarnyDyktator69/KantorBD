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
            MenuPanel = new Panel();
            buttonMoneyTransfer = new PictureBox();
            buttonHome = new PictureBox();
            buttonCurrencyExchange = new PictureBox();
            buttonSettings = new PictureBox();
            buttonWallet = new PictureBox();
            buttonHistory = new PictureBox();
            buttonLogOut = new PictureBox();
            labelClose = new Label();
            listViewTransaction = new ListView();
            labelTransactionI = new Label();
            buttonClear = new Button();
            buttonSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            buttonLast = new Button();
            buttonNext = new Button();
            buttonPrevious = new Button();
            buttonFirst = new Button();
            comboBoxCurrencyCodes = new ComboBox();
            comboBoxToCurrencyCodes = new ComboBox();
            label1 = new Label();
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
            // listViewTransaction
            // 
            listViewTransaction.Location = new Point(54, 180);
            listViewTransaction.Name = "listViewTransaction";
            listViewTransaction.Size = new Size(955, 214);
            listViewTransaction.TabIndex = 110;
            listViewTransaction.UseCompatibleStateImageBehavior = false;
            // 
            // labelTransactionI
            // 
            labelTransactionI.AutoSize = true;
            labelTransactionI.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelTransactionI.ForeColor = Color.FromArgb(255, 193, 37);
            labelTransactionI.Location = new Point(870, 397);
            labelTransactionI.Name = "labelTransactionI";
            labelTransactionI.Size = new Size(92, 23);
            labelTransactionI.TabIndex = 111;
            labelTransactionI.Text = "100 Users";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(16, 9, 48);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonClear.ForeColor = Color.FromArgb(255, 193, 37);
            buttonClear.Location = new Point(541, 605);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 50);
            buttonClear.TabIndex = 121;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(16, 9, 48);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSearch.ForeColor = Color.FromArgb(255, 193, 37);
            buttonSearch.Location = new Point(369, 605);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 50);
            buttonSearch.TabIndex = 120;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(625, 546);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 119;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(255, 193, 37);
            label6.Location = new Point(625, 507);
            label6.Name = "label6";
            label6.Size = new Size(233, 29);
            label6.TabIndex = 118;
            label6.Text = "TRANSACTION DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(195, 507);
            label5.Name = "label5";
            label5.Size = new Size(187, 29);
            label5.TabIndex = 116;
            label5.Text = "FROM CURRENCY";
            // 
            // buttonLast
            // 
            buttonLast.BackColor = Color.FromArgb(16, 9, 48);
            buttonLast.FlatStyle = FlatStyle.Flat;
            buttonLast.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonLast.ForeColor = Color.FromArgb(255, 193, 37);
            buttonLast.Location = new Point(708, 434);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(150, 50);
            buttonLast.TabIndex = 115;
            buttonLast.Text = ">>";
            buttonLast.UseVisualStyleBackColor = false;
            buttonLast.Click += buttonLast_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(16, 9, 48);
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonNext.ForeColor = Color.FromArgb(255, 193, 37);
            buttonNext.Location = new Point(541, 434);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(150, 50);
            buttonNext.TabIndex = 114;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.FromArgb(16, 9, 48);
            buttonPrevious.FlatStyle = FlatStyle.Flat;
            buttonPrevious.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonPrevious.ForeColor = Color.FromArgb(255, 193, 37);
            buttonPrevious.Location = new Point(369, 434);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(150, 50);
            buttonPrevious.TabIndex = 113;
            buttonPrevious.Text = "<";
            buttonPrevious.UseVisualStyleBackColor = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonFirst
            // 
            buttonFirst.BackColor = Color.FromArgb(16, 9, 48);
            buttonFirst.FlatStyle = FlatStyle.Flat;
            buttonFirst.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonFirst.ForeColor = Color.FromArgb(255, 193, 37);
            buttonFirst.Location = new Point(195, 434);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(150, 50);
            buttonFirst.TabIndex = 112;
            buttonFirst.Text = "<<";
            buttonFirst.UseVisualStyleBackColor = false;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // comboBoxCurrencyCodes
            // 
            comboBoxCurrencyCodes.FormattingEnabled = true;
            comboBoxCurrencyCodes.Location = new Point(195, 546);
            comboBoxCurrencyCodes.Name = "comboBoxCurrencyCodes";
            comboBoxCurrencyCodes.Size = new Size(187, 23);
            comboBoxCurrencyCodes.TabIndex = 122;
            // 
            // comboBoxToCurrencyCodes
            // 
            comboBoxToCurrencyCodes.FormattingEnabled = true;
            comboBoxToCurrencyCodes.Location = new Point(412, 546);
            comboBoxToCurrencyCodes.Name = "comboBoxToCurrencyCodes";
            comboBoxToCurrencyCodes.Size = new Size(187, 23);
            comboBoxToCurrencyCodes.TabIndex = 124;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 193, 37);
            label1.Location = new Point(429, 507);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 123;
            label1.Text = "TO CURRENCY";
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(comboBoxToCurrencyCodes);
            Controls.Add(label1);
            Controls.Add(comboBoxCurrencyCodes);
            Controls.Add(buttonClear);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonLast);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonFirst);
            Controls.Add(labelTransactionI);
            Controls.Add(listViewTransaction);
            Controls.Add(MenuPanel);
            Controls.Add(labelClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionHistory";
            Load += TransactionHistory_Load;
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
        private Panel MenuPanel;
        private PictureBox buttonMoneyTransfer;
        private PictureBox buttonHome;
        private PictureBox buttonCurrencyExchange;
        private PictureBox buttonSettings;
        private PictureBox buttonWallet;
        private PictureBox buttonHistory;
        private PictureBox buttonLogOut;
        private Label labelClose;
        private ListView listViewTransaction;
        private Label labelTransactionI;
        private Button buttonClear;
        private Button buttonSearch;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Button buttonLast;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonFirst;
        private ComboBox comboBoxCurrencyCodes;
        private ComboBox comboBoxToCurrencyCodes;
        private Label label1;
    }
}