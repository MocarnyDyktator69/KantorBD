using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class EditUserData : Form
    {
        private int loggedInUserID;
        private DB db;

        public EditUserData(int userID)
        {
            InitializeComponent();
            this.loggedInUserID = userID;
            db = new DB();

            DisplayUserData();
        }

        private void DisplayUserData()
        {
            string query = "SELECT u.*, c.cardNumber, c.expirationDate, c.cvv " +
                           "FROM `user` u " +
                           "LEFT JOIN creditcard c ON u.userID = c.userID " +
                           "WHERE u.userID = @userID";

            db.openConnection();
            using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
            {
                command.Parameters.AddWithValue("@userID", loggedInUserID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxName.Text = reader["name"].ToString();
                        textBoxSurname.Text = reader["surname"].ToString();
                        textBoxMail.Text = reader["email"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("cardNumber")))
                        {
                            textBoxCardNumber.Text = reader["cardNumber"].ToString();
                            textBoxCVV.Text = reader["cvv"].ToString();
                            textBoxExpirationDate.Text = reader["expirationDate"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                SaveUserData();
            }
            else
            {
                MessageBox.Show("Invalid data. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUserData()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(textBoxMail.Text))
            {
                return false;
            }

            if (!IsValidEmail(textBoxMail.Text))
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(textBoxCardNumber.Text) ||
                !string.IsNullOrWhiteSpace(textBoxCVV.Text) ||
                !string.IsNullOrWhiteSpace(textBoxExpirationDate.Text))
            {
                if (!IsValidCreditCardData())
                {
                    return false;
                }
            }

            if (!IsAlpha(textBoxName.Text) || !IsAlpha(textBoxSurname.Text))
            {
                return false;
            }

            return true;
        }

        private bool IsValidCreditCardData()
        {
            if (textBoxCardNumber.Text.Length != 16 || textBoxCVV.Text.Length != 3)
            {
                return false;
            }

            if (!IsValidExpirationDate(textBoxExpirationDate.Text))
            {
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidExpirationDate(string expirationDate)
        {
            Regex regex = new Regex(@"^(0[1-9]|1[0-2])\/\d{2}$");
            if (!regex.IsMatch(expirationDate))
            {
                return false;
            }

            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year % 100;
            string[] parts = expirationDate.Split('/');
            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);
            if (year < currentYear)
            {
                return false;
            }
            else if (year == currentYear && month < currentDate.Month)
            {
                return false;
            }

            return true;
        }

        private bool IsAlpha(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void SaveUserData()
        {
            string newName = textBoxName.Text;
            string newSurname = textBoxSurname.Text;
            string newMail = textBoxMail.Text;
            string newCardNumber = textBoxCardNumber.Text;
            string newCVV = textBoxCVV.Text;
            string newExpirationDate = textBoxExpirationDate.Text;

            if (!IsValidExpirationDate(newExpirationDate))
            {
                MessageBox.Show("Invalid expiration date format. Please use MM/YY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE `user` u " +
                           "LEFT JOIN creditcard c ON u.userID = c.userID " +
                           "SET u.name = @name, u.surname = @surname, u.email = @email, " +
                           "c.cardNumber = @cardNumber, c.cvv = @cvv, c.expirationDate = @expirationDate " +
                           "WHERE u.userID = @userID";

            db.openConnection();
            using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
            {
                command.Parameters.AddWithValue("@name", newName);
                command.Parameters.AddWithValue("@surname", newSurname);
                command.Parameters.AddWithValue("@email", newMail);
                command.Parameters.AddWithValue("@cardNumber", newCardNumber);
                command.Parameters.AddWithValue("@cvv", newCVV);
                command.Parameters.AddWithValue("@expirationDate", newExpirationDate);
                command.Parameters.AddWithValue("@userID", loggedInUserID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserAccount userAccount = new UserAccount(loggedInUserID);
                    userAccount.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("There was a problem saving the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory(loggedInUserID);
            transactionHistory.Show();
            this.Hide();
        }

        private void pictureBoxCurrencyExchange_Click(object sender, EventArgs e)
        {
            CurrencyExchange currencyExchange = new CurrencyExchange(loggedInUserID);
            currencyExchange.Show();
            this.Hide();
        }

        private void pictureBoxWallet_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet(loggedInUserID);
            wallet.Show();
            this.Hide();
        }

        private void pictureBoxMoneyTransfer_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneyTransfer = new MoneyTransfer(loggedInUserID);
            moneyTransfer.Show();
            this.Hide();
        }

        private void pictureBoxUserAccount_Click(object sender, EventArgs e)
        {
            UserAccount userAccount = new UserAccount(loggedInUserID);
            userAccount.Show();
            this.Hide();
        }

    }
}
