
namespace KantorBD
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 193, 37);
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 90);
            label1.TabIndex = 5;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(255, 193, 37);
            label2.Location = new Point(240, 174);
            label2.Name = "label2";
            label2.Size = new Size(137, 52);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(240, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 71);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox2.Location = new Point(240, 395);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(600, 71);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 193, 37);
            label3.Location = new Point(240, 340);
            label3.Name = "label3";
            label3.Size = new Size(190, 52);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(255, 193, 37);
            button1.Location = new Point(832, 609);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 10;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 640);
            label4.Name = "label4";
            label4.Size = new Size(277, 29);
            label4.TabIndex = 11;
            label4.Text = "You don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel1.LinkColor = Color.FromArgb(255, 193, 37);
            linkLabel1.Location = new Point(289, 640);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 29);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}