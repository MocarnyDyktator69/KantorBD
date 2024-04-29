using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class TransactionHistory : Form
    {
        private DB db = new DB();

        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            db.openConnection();

            string query = "SELECT * FROM exchangeratehistory";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int transakcjaId = (int)reader["TransakcjaId"];
                DateTime dataTransakcji = (DateTime)reader["DataTransakcji"];
                string waluta = (string)reader["Waluta"];
                decimal kwota = (decimal)reader["Kwota"];
                string rodzajTransakcji = (string)reader["RodzajTransakcji"];

                string transakcjaInfo = $"Transakcja ID: {transakcjaId}, Data: {dataTransakcji}, Waluta: {waluta}, Kwota: {kwota}, Rodzaj: {rodzajTransakcji}";
                listBoxTransactions.Items.Add(transakcjaInfo);
            }

            reader.Close();
            db.closeConnection();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();
            transactionHistory.Show();
            this.Hide();
        }

        private void pictureBoxCurrencyExchange_Click(object sender, EventArgs e)
        {
            CurrencyExchange currencyExchange = new CurrencyExchange();
            currencyExchange.Show();
            this.Hide();
        }

        private void pictureBoxWallet_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet();
            wallet.Show();
            this.Hide();
        }
    }
}
