namespace KantorBD
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f2 = new LoginForm();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f3 = new RegisterForm();
            f3.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
