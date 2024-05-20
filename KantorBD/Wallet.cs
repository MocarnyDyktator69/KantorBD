using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class Wallet : Form
    {
        private int loggedInUserID;

        public Wallet(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            LoadWalletData();
        }

        private void LoadWalletData()
        {
            int walletID = GetUserWalletID(loggedInUserID);

            using (DB db = new DB())
            {
                db.openConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    string query = "SELECT wc.balance, c.currencyCode FROM walletcurrency wc " +
                                   "INNER JOIN currency c ON wc.currencyID = c.currencyID " +
                                   "WHERE wc.walletID = @walletID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@walletID", walletID);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal balance = reader.GetDecimal(0);
                                string currencyCode = reader.GetString(1);
                                UpdateLabel(currencyCode, balance);
                            }
                        }
                    }
                }
            }
        }

        private int GetUserWalletID(int userID)
        {
            int walletID = 0;
            using (DB db = new DB())
            {
                db.openConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    string query = "SELECT walletID FROM wallet WHERE userID = @userID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            walletID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            return walletID;
        }

        private void UpdateLabel(string currencyCode, decimal balance)
        {
            switch (currencyCode)
            {
                case "PLN":
                    labelPLN.Text = balance.ToString();
                    break;
                case "EUR":
                    labelEUR.Text = balance.ToString();
                    break;
                case "GBP":
                    labelGBP.Text = balance.ToString();
                    break;
                case "USD":
                    labelUSD.Text = balance.ToString();
                    break;
                default:
                    break;
            }
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
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.Show();
            this.Hide();
        }

        private void buttonAddFounds_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.Show();
            this.Hide();
        }
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedInUserID);
            home.Show();
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
