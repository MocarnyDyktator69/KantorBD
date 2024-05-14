namespace KantorBD
{
    partial class AdminUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUser));
            panel1 = new Panel();
            listViewUser = new ListView();
            labelUserI = new Label();
            buttonClear = new Button();
            comboBoxUserTypeId = new ComboBox();
            buttonLast = new Button();
            buttonNext = new Button();
            buttonPrevious = new Button();
            buttonFirst = new Button();
            buttonRemove = new Button();
            buttonEdit = new Button();
            buttonSearch = new Button();
            textBoxBirth = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            numericID = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            MenuPanel = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelClose = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericID).BeginInit();
            MenuPanel.SuspendLayout();
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
            panel1.Controls.Add(listViewUser);
            panel1.Controls.Add(labelUserI);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(comboBoxUserTypeId);
            panel1.Controls.Add(buttonLast);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(buttonPrevious);
            panel1.Controls.Add(buttonFirst);
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxBirth);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(numericID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MenuPanel);
            panel1.Controls.Add(labelClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 681);
            panel1.TabIndex = 1;
            // 
            // listViewUser
            // 
            listViewUser.Location = new Point(185, 180);
            listViewUser.Name = "listViewUser";
            listViewUser.Size = new Size(680, 214);
            listViewUser.TabIndex = 43;
            listViewUser.UseCompatibleStateImageBehavior = false;
            listViewUser.SelectedIndexChanged += listViewUser_SelectedIndexChanged;
            // 
            // labelUserI
            // 
            labelUserI.AutoSize = true;
            labelUserI.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelUserI.ForeColor = Color.FromArgb(255, 193, 37);
            labelUserI.Location = new Point(826, 397);
            labelUserI.Name = "labelUserI";
            labelUserI.Size = new Size(92, 23);
            labelUserI.TabIndex = 42;
            labelUserI.Text = "100 Users";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(16, 9, 48);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonClear.ForeColor = Color.FromArgb(255, 193, 37);
            buttonClear.Location = new Point(710, 606);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 50);
            buttonClear.TabIndex = 41;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboBoxUserTypeId
            // 
            comboBoxUserTypeId.FormattingEnabled = true;
            comboBoxUserTypeId.Items.AddRange(new object[] { "1", "2" });
            comboBoxUserTypeId.Location = new Point(898, 539);
            comboBoxUserTypeId.Name = "comboBoxUserTypeId";
            comboBoxUserTypeId.Size = new Size(121, 23);
            comboBoxUserTypeId.TabIndex = 40;
            // 
            // buttonLast
            // 
            buttonLast.BackColor = Color.FromArgb(16, 9, 48);
            buttonLast.FlatStyle = FlatStyle.Flat;
            buttonLast.Font = new Font("Comic Sans MS", 22.5F, FontStyle.Bold);
            buttonLast.ForeColor = Color.FromArgb(255, 193, 37);
            buttonLast.Location = new Point(710, 429);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(150, 50);
            buttonLast.TabIndex = 39;
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
            buttonNext.Location = new Point(543, 429);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(150, 50);
            buttonNext.TabIndex = 38;
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
            buttonPrevious.Location = new Point(371, 429);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(150, 50);
            buttonPrevious.TabIndex = 37;
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
            buttonFirst.Location = new Point(197, 429);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(150, 50);
            buttonFirst.TabIndex = 36;
            buttonFirst.Text = "<<";
            buttonFirst.UseVisualStyleBackColor = false;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(16, 9, 48);
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonRemove.ForeColor = Color.FromArgb(255, 193, 37);
            buttonRemove.Location = new Point(543, 606);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(150, 50);
            buttonRemove.TabIndex = 35;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(16, 9, 48);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonEdit.ForeColor = Color.FromArgb(255, 193, 37);
            buttonEdit.Location = new Point(371, 606);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 50);
            buttonEdit.TabIndex = 34;
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
            buttonSearch.Location = new Point(197, 606);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 50);
            buttonSearch.TabIndex = 32;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxBirth
            // 
            textBoxBirth.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxBirth.Location = new Point(702, 539);
            textBoxBirth.Name = "textBoxBirth";
            textBoxBirth.Size = new Size(163, 35);
            textBoxBirth.TabIndex = 30;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxEmail.Location = new Point(485, 539);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(195, 35);
            textBoxEmail.TabIndex = 29;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxSurname.Location = new Point(309, 539);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(170, 35);
            textBoxSurname.TabIndex = 28;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxName.Location = new Point(131, 539);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 35);
            textBoxName.TabIndex = 27;
            // 
            // numericID
            // 
            numericID.Location = new Point(32, 539);
            numericID.Name = "numericID";
            numericID.Size = new Size(71, 23);
            numericID.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.FromArgb(255, 193, 37);
            label7.Location = new Point(893, 503);
            label7.Name = "label7";
            label7.Size = new Size(126, 29);
            label7.TabIndex = 25;
            label7.Text = "USER TYPE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(255, 193, 37);
            label6.Location = new Point(712, 503);
            label6.Name = "label6";
            label6.Size = new Size(143, 29);
            label6.TabIndex = 24;
            label6.Text = "BIRTH DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(535, 503);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 23;
            label5.Text = "E-MAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(255, 193, 37);
            label4.Location = new Point(339, 503);
            label4.Name = "label4";
            label4.Size = new Size(116, 29);
            label4.TabIndex = 22;
            label4.Text = "SURNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(179, 503);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 21;
            label3.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(52, 503);
            label2.Name = "label2";
            label2.Size = new Size(38, 29);
            label2.TabIndex = 20;
            label2.Text = "ID";
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(16, 9, 48);
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
            // AdminUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminUser";
            Load += AdminUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericID).EndInit();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxName;
        private NumericUpDown numericID;
        private TextBox textBoxBirth;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private Button buttonSearch;
        private Button buttonRemove;
        private Button buttonEdit;
        private Button buttonLast;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonFirst;
        private ComboBox comboBoxUserTypeId;
        private Button buttonClear;
        private Label labelUserI;
        private ListView listViewUser;
    }
}