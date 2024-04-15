namespace KantorBD
{
    partial class RegisterForm
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
            panel1 = new Panel();
            labelClose = new Label();
            label8 = new Label();
            buttonSigUp = new Button();
            linkLabelSignIn = new LinkLabel();
            label7 = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxBirth = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 26, 82);
            panel1.Controls.Add(labelClose);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonSigUp);
            panel1.Controls.Add(linkLabelSignIn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxBirth);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 681);
            panel1.TabIndex = 0;
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
            labelClose.TabIndex = 21;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.FromArgb(255, 193, 37);
            label8.Location = new Point(12, 602);
            label8.Name = "label8";
            label8.Size = new Size(161, 29);
            label8.TabIndex = 20;
            label8.Text = "*YYYY-MM-DD";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSigUp
            // 
            buttonSigUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSigUp.Cursor = Cursors.Hand;
            buttonSigUp.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSigUp.ForeColor = Color.FromArgb(255, 193, 37);
            buttonSigUp.Location = new Point(849, 602);
            buttonSigUp.Name = "buttonSigUp";
            buttonSigUp.Size = new Size(203, 67);
            buttonSigUp.TabIndex = 19;
            buttonSigUp.Text = "Sign Up";
            buttonSigUp.UseVisualStyleBackColor = true;
            buttonSigUp.Click += buttonSigUp_Click;
            // 
            // linkLabelSignIn
            // 
            linkLabelSignIn.AutoSize = true;
            linkLabelSignIn.Cursor = Cursors.Hand;
            linkLabelSignIn.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabelSignIn.LinkColor = Color.FromArgb(255, 193, 37);
            linkLabelSignIn.Location = new Point(295, 643);
            linkLabelSignIn.Name = "linkLabelSignIn";
            linkLabelSignIn.Size = new Size(84, 29);
            linkLabelSignIn.TabIndex = 18;
            linkLabelSignIn.TabStop = true;
            linkLabelSignIn.Text = "Sign In";
            linkLabelSignIn.TextAlign = ContentAlignment.MiddleLeft;
            linkLabelSignIn.Click += linkLabelSignIn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 643);
            label7.Name = "label7";
            label7.Size = new Size(277, 29);
            label7.TabIndex = 17;
            label7.Text = "You don't have an account?";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 27.75F);
            textBoxPassword.Location = new Point(314, 359);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(600, 59);
            textBoxPassword.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Comic Sans MS", 27.75F);
            textBoxEmail.Location = new Point(314, 279);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(600, 59);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxBirth
            // 
            textBoxBirth.Font = new Font("Comic Sans MS", 27.75F);
            textBoxBirth.ForeColor = Color.Black;
            textBoxBirth.Location = new Point(314, 438);
            textBoxBirth.Name = "textBoxBirth";
            textBoxBirth.Size = new Size(600, 59);
            textBoxBirth.TabIndex = 14;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Comic Sans MS", 27.75F);
            textBoxSurname.Location = new Point(314, 199);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(600, 59);
            textBoxSurname.TabIndex = 13;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Comic Sans MS", 27.75F);
            textBoxName.Location = new Point(314, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(600, 59);
            textBoxName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(255, 193, 37);
            label6.Location = new Point(51, 362);
            label6.Name = "label6";
            label6.Size = new Size(190, 52);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(255, 193, 37);
            label5.Location = new Point(51, 282);
            label5.Name = "label5";
            label5.Size = new Size(137, 52);
            label5.TabIndex = 10;
            label5.Text = "E-mail:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(255, 193, 37);
            label4.Location = new Point(51, 441);
            label4.Name = "label4";
            label4.Size = new Size(266, 52);
            label4.TabIndex = 9;
            label4.Text = "Date of bird*:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(51, 202);
            label3.Name = "label3";
            label3.Size = new Size(182, 52);
            label3.TabIndex = 8;
            label3.Text = "Surname:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(51, 125);
            label2.Name = "label2";
            label2.Size = new Size(130, 52);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F);
            label1.ForeColor = Color.FromArgb(255, 193, 37);
            label1.Location = new Point(389, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 90);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Enter += textBoxBirth_Enter;
            Leave += textBoxBirth_Leave;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxBirth;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label7;
        private LinkLabel linkLabelSignIn;
        private Button buttonSigUp;
        private Label label8;
        private Label labelClose;
    }
}