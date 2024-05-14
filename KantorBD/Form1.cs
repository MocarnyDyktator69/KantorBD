using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace KantorBD
{
    public partial class CurrencyExchange : Form
    {
        private int loggedInUserID;
        private DB db;

        public CurrencyExchange(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            db = new DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromCurrencyBox.SelectedItem = "USD";
            ToCurrencyBox.SelectedItem = "PLN";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://v6.exchangerate-api.com/v6/b9f4c7090a7d9ee239826cc5/latest/{fromCurrency}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["conversion_rates"][toCurrency];

            return rate;
        }

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyBox.SelectedItem.ToString();
            string toCurrency = ToCurrencyBox.SelectedItem.ToString();

            double amount;
            if (!double.TryParse(AmmountToConvertBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to convert.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving the exchange rate!", "Error - API error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;
            ConvertedAmountDisplay.Text = $"{convertedAmount.ToString("F2")}";

            double balance;
            using (MySqlConnection connection = db.getConnection())
            {
                string query = "SELECT balance FROM walletcurrency WHERE walletID = @WalletID AND currencyID = @CurrencyID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WalletID", GetWalletID(loggedInUserID));
                    command.Parameters.AddWithValue("@CurrencyID", GetCurrencyID(fromCurrency));
                    connection.Open();
                    balance = Convert.ToDouble(command.ExecuteScalar());
                }
            }

            if (balance < amount)
            {
                MessageBox.Show("You don't have enough funds to complete this transaction.", "Insufficient Funds", MessageBoxButtons.OK);
                return;
            }

            using (MySqlConnection connection = db.getConnection())
            {
                string insertQuery = "INSERT INTO transactions (userID, walletID, fromCurrencyID, toCurrencyID, amount, exchangeRate, transactionType, transactionDate) VALUES (@UserID, @WalletID, @FromCurrencyID, @ToCurrencyID, @Amount, @ExchangeRate, @TransactionType, @TransactionDate)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", loggedInUserID);
                    command.Parameters.AddWithValue("@WalletID", GetWalletID(loggedInUserID));
                    command.Parameters.AddWithValue("@FromCurrencyID", GetCurrencyID(fromCurrency));
                    command.Parameters.AddWithValue("@ToCurrencyID", GetCurrencyID(toCurrency));
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@ExchangeRate", exchangeRate);
                    command.Parameters.AddWithValue("@TransactionType", "exchange");
                    command.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK);
        }

        private int GetCurrencyID(string currencyCode)
        {
            int currencyID;
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = db.getConnection();
                command.CommandText = "SELECT currencyID FROM currency WHERE currencyCode = @CurrencyCode";
                command.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                db.openConnection();
                currencyID = Convert.ToInt32(command.ExecuteScalar());
                db.closeConnection();
            }
            return currencyID;
        }

        private int GetWalletID(int userID)
        {
            int walletID;
            using (MySqlCommand command = new MySqlCommand())
            {
                command.Connection = db.getConnection();
                command.CommandText = "SELECT walletID FROM wallet WHERE userID = @UserID";
                command.Parameters.AddWithValue("@UserID", userID);
                db.openConnection();
                walletID = Convert.ToInt32(command.ExecuteScalar());
            }
            return walletID;
        }



        private void rateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCurrency = rateBox.SelectedItem.ToString();

            try
            {
                double usdRate = GetExchangeRate(selectedCurrency, "USD");
                double eurRate = GetExchangeRate(selectedCurrency, "EUR");
                double gbpRate = GetExchangeRate(selectedCurrency, "GBP");
                double plnRate = GetExchangeRate(selectedCurrency, "PLN");

                labelUSD.Text = $"{usdRate.ToString("F4")}";
                labelEUR.Text = $"{eurRate.ToString("F4")}";
                labelGBP.Text = $"{gbpRate.ToString("F4")}";
                labelPLN.Text = $"{plnRate.ToString("F4")}";
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving exchange rates!", "Error - API error", MessageBoxButtons.OK);
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
    }
}