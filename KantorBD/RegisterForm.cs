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

        DB db = new DB();

        private void buttonSigUp_Click(object sender, EventArgs e)
        {
            RegUserDTO user = new RegUserDTO
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Email = textBoxEmail.Text,
                PasswordHash = HashPassword(textBoxPassword.Text),
                BirthDate = textBoxBirth.Text
            };

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (checkEmail())
                {
                    MessageBox.Show("This email already exists, please enter another one");
                }
                else
                {
                    if (InsertUser(user))
                    {
                        MessageBox.Show("Account created");
                        long walletID = InsertWalletAndWalletCurrencies(user);
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

        private bool InsertUser(RegUserDTO user)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`name`, `surname`, `email`, `password`, `birth_date`) VALUES (@fn,@fs,@email,@h,@b)", db.getConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = user.Name;
            command.Parameters.Add("@fs", MySqlDbType.VarChar).Value = user.Surname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@h", MySqlDbType.VarChar).Value = user.PasswordHash;
            command.Parameters.Add("@b", MySqlDbType.VarChar).Value = user.BirthDate;

            return command.ExecuteNonQuery() == 1;
        }

        private long InsertWalletAndWalletCurrencies(RegUserDTO user)
        {
            MySqlCommand walletCommand = new MySqlCommand("INSERT INTO `wallet`(`userID`) VALUES (LAST_INSERT_ID())", db.getConnection());
            walletCommand.ExecuteNonQuery();

            long walletID = walletCommand.LastInsertedId;

            MySqlCommand walletCurrencyCommand = new MySqlCommand("INSERT INTO `walletcurrency`(`walletID`, `currencyID`) VALUES (@wID, 1), (@wID, 2), (@wID, 3), (@wID, 4)", db.getConnection());
            walletCurrencyCommand.Parameters.Add("@wID", MySqlDbType.Int64).Value = walletID;
            walletCurrencyCommand.ExecuteNonQuery();

            return walletID;
        }

        public Boolean checkEmail()
        {
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
    public class RegUserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string BirthDate { get; set; }
    }

}
