using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class UserAccount : Form
    {
        private int loggedInUserID;
        private DB db;

        public UserAccount(int userID)
        {
            InitializeComponent();
            this.loggedInUserID = userID;
            db = new DB();
            LoadUserData();
        }

        private void LoadUserData()
        {
            string query = "SELECT u.name, u.surname, u.email, c.cardNumber " +
                           "FROM `user` u " +
                           "LEFT JOIN creditcard c ON u.userID = c.userID " +
                           "WHERE u.userID = @userID";

            using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
            {
                command.Parameters.AddWithValue("@userID", loggedInUserID);

                try
                {
                    db.openConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelName.Text = "Name: " + reader["name"].ToString();
                            labelSurname.Text = "Surname: " + reader["surname"].ToString();
                            labelMail.Text = "Email: " + reader["email"].ToString();
                            if (!reader.IsDBNull(reader.GetOrdinal("cardNumber")))
                            {
                                labelCardNumber.Text = "Card Number: " + reader["cardNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No card number found for this user.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for this user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading user data: " + ex.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            EditUserData editUserData = new EditUserData(loggedInUserID);
            editUserData.Show();
            this.Hide();
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
