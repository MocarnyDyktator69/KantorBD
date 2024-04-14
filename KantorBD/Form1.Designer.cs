namespace KantorBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(255, 193, 37);
            button1.Location = new Point(315, 430);
            button1.Name = "button1";
            button1.Size = new Size(450, 100);
            button1.TabIndex = 0;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 330);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Comic Sans MS", 54F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 193, 37);
            label1.Location = new Point(316, 316);
            label1.Name = "label1";
            label1.Size = new Size(448, 100);
            label1.TabIndex = 4;
            label1.Text = "KANTOREX";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.FromArgb(255, 193, 37);
            button3.Location = new Point(314, 560);
            button3.Name = "button3";
            button3.Size = new Size(450, 100);
            button3.TabIndex = 0;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 26, 82);
            ClientSize = new Size(1064, 681);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
    }
}
