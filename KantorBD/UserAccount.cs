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
        private UserAccountDTO userData;

        public UserAccount(int userID)
        {
            InitializeComponent();
            this.loggedInUserID = userID;
            db = new DB();
            LoadUserData();
        }

        private void LoadUserData()
        {
            string query = "CALL GetUserAccountData(@userID)";

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
                            userData = new UserAccountDTO
                            {
                                Name = reader["name"].ToString(),
                                Surname = reader["surname"].ToString(),
                                Email = reader["email"].ToString(),
                                CardNumber = reader.IsDBNull(reader.GetOrdinal("cardNumber")) ? null : reader["cardNumber"].ToString()
                            };

                            DisplayUserData();
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

        private void DisplayUserData()
        {
            labelName.Text = "Name: " + userData.Name;
            labelSurname.Text = "Surname: " + userData.Surname;
            labelMail.Text = "Email: " + userData.Email;

            if (userData.CardNumber != null)
            {
                labelCardNumber.Text = "Card Number: " + userData.CardNumber;
            }
            else
            {
                MessageBox.Show("No card number found for this user.");
            }
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUserData editUserData = new EditUserData(loggedInUserID);
            editUserData.Show();
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

    public class UserAccountDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
    }
}
