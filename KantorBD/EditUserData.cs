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

            string updateUserQuery = "UPDATE `user` SET name = @name, surname = @surname, email = @mail WHERE userID = @userID";
            string checkCardQuery = "SELECT COUNT(*) FROM creditcard WHERE userID = @userID";
            string updateCardQuery = "UPDATE creditcard SET cardNumber = @cardNumber, cvv = @cvv, expirationDate = @expirationDate WHERE userID = @userID";
            string insertCardQuery = "INSERT INTO creditcard (userID, cardNumber, cvv, expirationDate) VALUES (@userID, @cardNumber, @cvv, @expirationDate)";

            db.openConnection();

            using (MySqlCommand updateUserCommand = new MySqlCommand(updateUserQuery, db.getConnection()))
            {
                updateUserCommand.Parameters.AddWithValue("@name", newName);
                updateUserCommand.Parameters.AddWithValue("@surname", newSurname);
                updateUserCommand.Parameters.AddWithValue("@mail", newMail);
                updateUserCommand.Parameters.AddWithValue("@userID", loggedInUserID);
                updateUserCommand.ExecuteNonQuery();
            }

            using (MySqlCommand checkCardCommand = new MySqlCommand(checkCardQuery, db.getConnection()))
            {
                checkCardCommand.Parameters.AddWithValue("@userID", loggedInUserID);
                int cardCount = Convert.ToInt32(checkCardCommand.ExecuteScalar());

                if (cardCount > 0)
                {
                    using (MySqlCommand updateCardCommand = new MySqlCommand(updateCardQuery, db.getConnection()))
                    {
                        updateCardCommand.Parameters.AddWithValue("@cardNumber", newCardNumber);
                        updateCardCommand.Parameters.AddWithValue("@cvv", newCVV);
                        updateCardCommand.Parameters.AddWithValue("@expirationDate", newExpirationDate);
                        updateCardCommand.Parameters.AddWithValue("@userID", loggedInUserID);
                        updateCardCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (MySqlCommand insertCardCommand = new MySqlCommand(insertCardQuery, db.getConnection()))
                    {
                        insertCardCommand.Parameters.AddWithValue("@cardNumber", newCardNumber);
                        insertCardCommand.Parameters.AddWithValue("@cvv", newCVV);
                        insertCardCommand.Parameters.AddWithValue("@expirationDate", newExpirationDate);
                        insertCardCommand.Parameters.AddWithValue("@userID", loggedInUserID);
                        insertCardCommand.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Data has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserAccount userAccount = new UserAccount(loggedInUserID);
            userAccount.Show();
            this.Hide();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(loggedInUserID);
            home.Show();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(loggedInUserID);
            home.Show();
        }

        private void buttonWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wallet wallet = new Wallet(loggedInUserID);
            wallet.Show();
        }

        private void buttonCurrencyExchange_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrencyExchange currencyExchange = new CurrencyExchange(loggedInUserID);
            currencyExchange.Show();
        }

        private void buttonMoneyTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoneyTransfer moneyTransfer = new MoneyTransfer(loggedInUserID);
            moneyTransfer.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionHistory transactionHistory = new TransactionHistory(loggedInUserID);
            transactionHistory.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccount userAccount = new UserAccount(loggedInUserID);
            userAccount.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm f5 = new StartForm();
            f5.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
