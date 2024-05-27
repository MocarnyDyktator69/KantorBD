using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class ExchangeRateHistory : Form
    {
        private int loggedInUserID;

        public ExchangeRateHistory(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            LoadExchangeRateHistory();
        }

        public class ExchangeRateHistoryDTO
        {
            public int Id { get; set; }
            public int FromCurrencyID { get; set; }
            public int ToCurrencyID { get; set; }
            public double Rate { get; set; }
            public DateTime UpdatedOn { get; set; }
        }

        private void LoadExchangeRateHistory()
        {
            List<ExchangeRateHistoryDTO> exchangeRateHistory = GetExchangeRateHistory();

            listView1.View = View.Details;
            listView1.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("From Currency ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("To Currency ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Rate", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Updated On", -2, HorizontalAlignment.Left);

            foreach (var record in exchangeRateHistory)
            {
                ListViewItem item = new ListViewItem(record.Id.ToString());
                item.SubItems.Add(record.FromCurrencyID.ToString());
                item.SubItems.Add(record.ToCurrencyID.ToString());
                item.SubItems.Add(record.Rate.ToString("F4"));
                item.SubItems.Add(record.UpdatedOn.ToString());

                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private List<ExchangeRateHistoryDTO> GetExchangeRateHistory()
        {
            string query = "SELECT * FROM exchangeratehistory";
            List<ExchangeRateHistoryDTO> historyList = new List<ExchangeRateHistoryDTO>();

            using (DB db = new DB())
            {
                db.openConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    historyList.Add(new ExchangeRateHistoryDTO
                    {
                        Id = reader.GetInt32("id"),
                        FromCurrencyID = reader.GetInt32("fromCurrencyID"),
                        ToCurrencyID = reader.GetInt32("toCurrencyID"),
                        Rate = reader.GetDouble("rate"),
                        UpdatedOn = reader.GetDateTime("updatedOn")
                    });
                }

                db.closeConnection();
            }

            return historyList;
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
