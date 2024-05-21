
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
using System.Security.Cryptography;

namespace KantorBD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        DB db = new DB();

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            LogUserDTO user = new LogUserDTO()
            {
                Email = textBoxEmail.Text,
                Password = HashPassword(textBoxPassword.Text)
            };

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `userID`, `email`, `password`, `usertypeID` FROM `user` WHERE `email` = @uE AND `password` = @uH", db.getConnection());

            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@uH", MySqlDbType.VarChar).Value = user.Password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                user.UserID = Convert.ToInt32(table.Rows[0]["userID"]);
                user.UserTypeID = Convert.ToInt32(table.Rows[0]["usertypeID"]);

                this.Hide();

                if (user.UserTypeID == 1) // admin
                {
                    MainAdminForm f1 = new MainAdminForm();
                    f1.Show();
                }
                else if (user.UserTypeID == 2) // user
                {
                    int UserID = Convert.ToInt32(table.Rows[0]["userID"]);

                    Home f2 = new Home(UserID);
                    f2.Show();
                }
            }
            else
            {
                if (user.Email.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your email to login", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user.Password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
    public class LogUserDTO
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
    }
}
