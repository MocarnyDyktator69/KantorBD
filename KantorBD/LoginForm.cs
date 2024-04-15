
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KantorBD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String email = textBoxEmail.Text;
            String haslo = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `email` = @uE AND `haslo` = @uH", db.getConnection());

            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uH", MySqlDbType.VarChar).Value = haslo;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Sukces!");
            }
            else
            {
                if (email.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your email to login", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (email.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f3 = new RegisterForm();
            f3.Show();
        }
    }
}
