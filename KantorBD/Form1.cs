using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace KantorBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

    }
}
