namespace KantorBD
{
    partial class AdminWalletcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWalletcs));
            panel1 = new Panel();
            buttonClear = new Button();
            comboBoxCurrency = new ComboBox();
            buttonEdit = new Button();
            buttonSearch = new Button();
            textBoxBalance = new TextBox();
            textBoxEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listViewWallet = new ListView();
            labelWalletI = new Label();
            buttonLast = new Button();
            buttonNext = new Button();
            buttonPrevious = new Button();
            buttonFirst = new Button();
            MenuPanel = new Panel();
            pictureNotifiBox = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelClose = new Label();
            panel1.SuspendLayout();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureNotifiBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 26, 82);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(comboBoxCurrency);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxBalance);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(listViewWallet);
            panel1.Controls.Add(labelWalletI);
            panel1.Controls.Add(buttonLast);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(buttonPrevious);
            panel1.Controls.Add(buttonFirst);
            panel1.Controls.Add(MenuPanel);
            panel1.Controls.Add(labelClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 681);
            panel1.TabIndex = 1;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(16, 9, 48);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonClear.ForeColor = Color.FromArgb(255, 193, 37);
            buttonClear.Location = new Point(634, 601);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 50);
            buttonClear.TabIndex = 58;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(483, 547);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(121, 23);
            comboBoxCurrency.TabIndex = 57;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(16, 9, 48);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonEdit.ForeColor = Color.FromArgb(255, 193, 37);
            buttonEdit.Location = new Point(460, 601);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 50);
            buttonEdit.TabIndex = 56;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(16, 9, 48);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSearch.ForeColor = Color.FromArgb(255, 193, 37);
            buttonSearch.Location = new Point(286, 601);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 50);
            buttonSearch.TabIndex = 55;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxBalance.Location = new Point(631, 537);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(225, 35);
            textBoxBalance.TabIndex = 54;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxEmail.Location = new Point(232, 537);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(225, 35);
            textBoxEmail.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.FromArgb(255, 193, 37);
            label7.Location = new Point(483, 501);
            label7.Name = "label7";
            label7.Size = new Size(119, 29);
            label7.TabIndex = 52;
            label7.Text = "CURRENCY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(255, 193, 37);
            label6.Location = new Point(689, 501);
            label6.Name = "label6";
            label6.Size = new Size(107, 29);
            label6.TabIndex = 51;
            label6.Text = "BALANCE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(304, 501);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 50;
            label5.Text = "E-MAIL";
            // 
            // listViewWallet
            // 
            listViewWallet.Location = new Point(198, 180);
            listViewWallet.Name = "listViewWallet";
            listViewWallet.Size = new Size(655, 214);
            listViewWallet.TabIndex = 49;
            listViewWallet.UseCompatibleStateImageBehavior = false;
            listViewWallet.SelectedIndexChanged += listViewWallet_SelectedIndexChanged;
            // 
            // labelWalletI
            // 
            labelWalletI.AutoSize = true;
            labelWalletI.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelWalletI.ForeColor = Color.FromArgb(255, 193, 37);
            labelWalletI.Location = new Point(755, 397);
            labelWalletI.Name = "labelWalletI";
            labelWalletI.Size = new Size(106, 23);
            labelWalletI.TabIndex = 48;
            labelWalletI.Text = "100 Wallets";
            // 
            // buttonLast
            // 
            buttonLast.BackColor = Color.FromArgb(16, 9, 48);
            buttonLast.FlatStyle = FlatStyle.Flat;
            buttonLast.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonLast.ForeColor = Color.FromArgb(255, 193, 37);
            buttonLast.Location = new Point(706, 429);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(150, 50);
            buttonLast.TabIndex = 47;
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
            buttonNext.Location = new Point(539, 429);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(150, 50);
            buttonNext.TabIndex = 46;
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
            buttonPrevious.Location = new Point(367, 429);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(150, 50);
            buttonPrevious.TabIndex = 45;
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
            buttonFirst.Location = new Point(193, 429);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(150, 50);
            buttonFirst.TabIndex = 44;
            buttonFirst.Text = "<<";
            buttonFirst.UseVisualStyleBackColor = false;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(16, 9, 48);
            MenuPanel.Controls.Add(pictureNotifiBox);
            MenuPanel.Controls.Add(pictureBox6);
            MenuPanel.Controls.Add(pictureBox5);
            MenuPanel.Controls.Add(pictureBox4);
            MenuPanel.Controls.Add(pictureBox3);
            MenuPanel.Controls.Add(pictureBox2);
            MenuPanel.Controls.Add(pictureBox1);
            MenuPanel.Location = new Point(0, 64);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1064, 110);
            MenuPanel.TabIndex = 16;
            // 
            // pictureNotifiBox
            // 
            pictureNotifiBox.Image = (Image)resources.GetObject("pictureNotifiBox.Image");
            pictureNotifiBox.Location = new Point(346, 20);
            pictureNotifiBox.Name = "pictureNotifiBox";
            pictureNotifiBox.Size = new Size(65, 65);
            pictureNotifiBox.TabIndex = 20;
            pictureNotifiBox.TabStop = false;
            pictureNotifiBox.Click += pictureNotifiBox_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(444, 20);
            pictureBox6.Margin = new Padding(5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(65, 65);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(744, 20);
            pictureBox5.Margin = new Padding(5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 65);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(844, 20);
            pictureBox4.Margin = new Padding(5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 65);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(644, 20);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(544, 20);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(16, 9, 48);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(944, 20);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            labelClose.TabIndex = 15;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // AdminWalletcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminWalletcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminWalletcs";
            Load += AdminWalletcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureNotifiBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pictureNotifiBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel MenuPanel;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelClose;
        private PictureBox pictureBox6;
        private ListView listViewWallet;
        private Label labelWalletI;
        private Button buttonLast;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonFirst;
        private Button buttonClear;
        private ComboBox comboBoxCurrency;
        private Button buttonEdit;
        private Button buttonSearch;
        private TextBox textBoxBalance;
        private TextBox textBoxEmail;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureNotifiBox;
    }
}