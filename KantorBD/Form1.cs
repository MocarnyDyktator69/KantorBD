using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace KantorBD
{
    public partial class CurrencyExchange : Form
    {
        private int loggedInUserID;
        private DB db;
        private const decimal MaxExchangeLimit = 10000m;

        public CurrencyExchange(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            db = new DB();
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
        {
            FromCurrencyBox.SelectedItem = "USD";
            ToCurrencyBox.SelectedItem = "PLN";
            rateBox.SelectedItem = "PLN";
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

            if (!decimal.TryParse(AmountToConvertBox.Text, out decimal amountToConvert) || amountToConvert <= 0)
            {
                MessageBox.Show("Please enter a valid amount to convert!", "Error - Invalid amount", MessageBoxButtons.OK);
                return;
            }

            if (amountToConvert > MaxExchangeLimit)
            {
                MessageBox.Show($"The amount to convert exceeds the maximum limit of {MaxExchangeLimit}!", "Error - Limit exceeded", MessageBoxButtons.OK);
                return;
            }

            decimal exchangeRate = (decimal)GetExchangeRate(fromCurrency, toCurrency);
            decimal convertedAmount = amountToConvert * exchangeRate;

            try
            {
                db.openConnection();

                MySqlCommand command = new MySqlCommand("SELECT currencyID FROM currency WHERE currencyCode = @fromCurrency", db.getConnection());
                command.Parameters.AddWithValue("@fromCurrency", fromCurrency);
                int fromCurrencyID = (int)command.ExecuteScalar();

                command = new MySqlCommand("SELECT currencyID FROM currency WHERE currencyCode = @toCurrency", db.getConnection());
                command.Parameters.AddWithValue("@toCurrency", toCurrency);
                int toCurrencyID = (int)command.ExecuteScalar();

                command = new MySqlCommand("SELECT balance FROM walletcurrency WHERE walletID = (SELECT walletID FROM wallet WHERE userID = @userID) AND currencyID = @fromCurrencyID", db.getConnection());
                command.Parameters.AddWithValue("@userID", loggedInUserID);
                command.Parameters.AddWithValue("@fromCurrencyID", fromCurrencyID);
                decimal currentBalance = (decimal)command.ExecuteScalar();

                if (currentBalance < amountToConvert)
                {
                    MessageBox.Show("You do not have enough funds to complete this exchange!", "Error - Insufficient funds", MessageBoxButtons.OK);
                    db.closeConnection();
                    return;
                }

                DateTime currentDate = DateTime.Now.Date;

                command = new MySqlCommand("INSERT INTO transactions (userID, fromCurrencyID, toCurrencyID, amount, exchangeRate, transactionType, transactionDate) VALUES (@userID, @fromCurrencyID, @toCurrencyID, @amount, @exchangeRate, 'exchange', @transactionDate)", db.getConnection());
                command.Parameters.AddWithValue("@userID", loggedInUserID);
                command.Parameters.AddWithValue("@fromCurrencyID", fromCurrencyID);
                command.Parameters.AddWithValue("@toCurrencyID", toCurrencyID);
                command.Parameters.AddWithValue("@amount", amountToConvert);
                command.Parameters.AddWithValue("@exchangeRate", exchangeRate);
                command.Parameters.AddWithValue("@transactionDate", currentDate.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();

                command = new MySqlCommand("UPDATE walletcurrency SET balance = balance - @amountToConvert WHERE walletID = (SELECT walletID FROM wallet WHERE userID = @userID) AND currencyID = @fromCurrencyID", db.getConnection());
                command.Parameters.AddWithValue("@amountToConvert", amountToConvert);
                command.Parameters.AddWithValue("@userID", loggedInUserID);
                command.Parameters.AddWithValue("@fromCurrencyID", fromCurrencyID);
                command.ExecuteNonQuery();

                command = new MySqlCommand("UPDATE walletcurrency SET balance = balance + @convertedAmount WHERE walletID = (SELECT walletID FROM wallet WHERE userID = @userID) AND currencyID = @toCurrencyID", db.getConnection());
                command.Parameters.AddWithValue("@convertedAmount", convertedAmount);
                command.Parameters.AddWithValue("@userID", loggedInUserID);
                command.Parameters.AddWithValue("@toCurrencyID", toCurrencyID);
                command.ExecuteNonQuery();

                db.closeConnection();

                MessageBox.Show($"{amountToConvert} {fromCurrency} has been successfully converted to {convertedAmount} {toCurrency}!", "Success - Currency exchange", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exchanging the currencies: {ex.Message}", "Error - Currency exchange", MessageBoxButtons.OK);
            }
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

                labelUSD.Text = $"{usdRate:F4}";
                labelEUR.Text = $"{eurRate:F4}";
                labelGBP.Text = $"{gbpRate:F4}";
                labelPLN.Text = $"{plnRate:F4}";
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving exchange rates!", "Error - API error", MessageBoxButtons.OK);
            }
        }

        private void AmountToConvertBox_TextChanged(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyBox.SelectedItem.ToString();
            string toCurrency = ToCurrencyBox.SelectedItem.ToString();

            if (!decimal.TryParse(AmountToConvertBox.Text, out decimal amountToConvert) || amountToConvert <= 0)
            {
                ConvertedAmountDisplay.Text = "Invalid amount";
                return;
            }

            if (amountToConvert > MaxExchangeLimit)
            {
                ConvertedAmountDisplay.Text = "Exceeds limit";
                return;
            }

            decimal exchangeRate = (decimal)GetExchangeRate(fromCurrency, toCurrency);
            decimal convertedAmount = amountToConvert * exchangeRate;

            ConvertedAmountDisplay.Text = $"{convertedAmount:F2}";
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
    }
}
