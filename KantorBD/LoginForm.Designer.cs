
namespace KantorBD
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonSigIn = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            labelClose = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 193, 37);
            label1.Location = new Point(391, 98);
            label1.Name = "label1";
            label1.Size = new Size(256, 90);
            label1.TabIndex = 5;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(218, 259);
            label2.Name = "label2";
            label2.Size = new Size(137, 52);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxEmail.Location = new Point(218, 314);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(600, 74);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxPassword.Location = new Point(218, 443);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(600, 74);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(218, 388);
            label3.Name = "label3";
            label3.Size = new Size(190, 52);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSigIn
            // 
            buttonSigIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSigIn.Cursor = Cursors.Hand;
            buttonSigIn.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSigIn.ForeColor = Color.FromArgb(255, 193, 37);
            buttonSigIn.Location = new Point(849, 602);
            buttonSigIn.Name = "buttonSigIn";
            buttonSigIn.Size = new Size(203, 67);
            buttonSigIn.TabIndex = 10;
            buttonSigIn.Text = "Sign In";
            buttonSigIn.UseVisualStyleBackColor = true;
            buttonSigIn.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 640);
            label4.Name = "label4";
            label4.Size = new Size(277, 29);
            label4.TabIndex = 11;
            label4.Text = "You don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel1.LinkColor = Color.FromArgb(255, 193, 37);
            linkLabel1.Location = new Point(297, 640);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 29);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(buttonSigIn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPassword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 681);
            panel1.TabIndex = 13;
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
            labelClose.TabIndex = 14;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonSigIn;
        private Label label4;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Label labelClose;
    }
}