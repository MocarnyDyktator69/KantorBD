using MySql.Data.MySqlClient;
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
    public partial class MainAdminForm : Form
    {
        public class CurrencyDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
        }

        public MainAdminForm()
        {
            InitializeComponent();

            List<CurrencyDTO> currencies = LoadCurrencies();

            foreach (CurrencyDTO currency in currencies)
            {
                rateBox.Items.Add(currency.Code);
            }

            rateBox.SelectedIndex = 0;
        }

        DB db = new DB();

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

        private List<CurrencyDTO> LoadCurrencies()
        {
            string query = "SELECT * FROM currency";
            List<CurrencyDTO> currencies = new List<CurrencyDTO>();

            using (MySqlConnection connection = new MySqlConnection(db.connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    currencies.Add(new CurrencyDTO
                    {
                        Id = reader.GetInt32("currencyID"),
                        Name = reader.GetString("currencyName"),
                        Code = reader.GetString("currencyCode")
                    });
                }

                connection.Close();
            }

            return currencies;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUser f1 = new AdminUser();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWalletcs f2 = new AdminWalletcs();
            f2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTransaction f3 = new AdminTransaction();
            f3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings f4 = new AdminSettings();
            f4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm f5 = new StartForm();
            f5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdminForm f6 = new MainAdminForm();
            f6.Show();
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
