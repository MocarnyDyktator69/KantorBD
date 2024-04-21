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
using System.Security.Cryptography;

namespace KantorBD
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBirth_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxBirth_Leave(object sender, EventArgs e)
        {

        }

        private void buttonSigUp_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`name`, `surname`, `email`, `password`, `birth_date`) VALUES (@fn,@fs,@email,@h,@b)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@fs", MySqlDbType.VarChar).Value = textBoxSurname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@h", MySqlDbType.VarChar).Value = HashPassword(textBoxPassword.Text);
            command.Parameters.Add("@b", MySqlDbType.VarChar).Value = textBoxBirth.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (checkEmail())
                {
                    MessageBox.Show("This email already exists, please enter another one");
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account created");
                        MySqlCommand walletCommand = new MySqlCommand("INSERT INTO `wallet`(`userID`) VALUES (LAST_INSERT_ID())", db.getConnection());
                        walletCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter your information first");
            }


            db.closeConnection();
        }

        public Boolean checkEmail()
        {
            DB db = new DB();

            String email = textBoxEmail.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `email` = @uE", db.getConnection());

            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkTextBoxesValues()
        {
            String name = textBoxName.Text;
            String surname = textBoxSurname.Text;
            String email = textBoxEmail.Text;
            String password = textBoxPassword.Text;
            String birth = textBoxBirth.Text;

            if (name.Equals("") || surname.Equals("") || email.Equals("") || password.Equals("") || birth.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void linkLabelSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f2 = new LoginForm();
            f2.Show();
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
}
