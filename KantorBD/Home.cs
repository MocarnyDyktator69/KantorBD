using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class Home : Form
    {
        private int loggedInUserID;
        public Home(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
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
