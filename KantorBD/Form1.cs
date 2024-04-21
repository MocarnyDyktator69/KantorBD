using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;


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
                json = client.DownloadString($"https://v6.exchangerate-api.com/v6/b9f4c7090a7d9ee239826cc5/latest/USD"); //{fromCurrency}
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public class Rate
        {
            public string no { get; set; }
            public string effectiveDate { get; set; }
            public double mid { get; set; }
        }

        public class Root
        {
            public string table { get; set; }
            public string currency { get; set; }
            public string code { get; set; }
            public List<Rate> rates { get; set; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertedAmmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmmountToConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertedAmountDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
