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
            var walletDataList = LoadWalletData();

            foreach (var walletData in walletDataList)
            {
                switch (walletData.CurrencyCode)
                {
                    case "PLN":
                        labelPLN.Text = walletData.Balance.ToString();
                        break;
                    case "EUR":
                        labelEUR.Text = walletData.Balance.ToString();
                        break;
                    case "GBP":
                        labelGBP.Text = walletData.Balance.ToString();
                        break;
                    case "USD":
                        labelUSD.Text = walletData.Balance.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private List<WalletDataDTO> LoadWalletData()
        {
            int walletID = GetUserWalletID(loggedInUserID);
            var walletDataList = new List<WalletDataDTO>();

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
                                var walletData = new WalletDataDTO { Balance = balance, CurrencyCode = currencyCode };
                                walletDataList.Add(walletData);
                            }
                        }
                    }
                }
            }

            return walletDataList;
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

        private void buttonAddFounds_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.Show();
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
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.Show();
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

    public class WalletDataDTO
    {
        public decimal Balance { get; set; }
        public string CurrencyCode { get; set; }
    }
}
