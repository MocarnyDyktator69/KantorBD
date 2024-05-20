using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class TransactionHistory : Form
    {
        private DB db = new DB();
        private int loggedInUserID;

        public TransactionHistory(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            db.openConnection();

            string query = "SELECT * FROM transactions WHERE userID = @userID";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@userID", loggedInUserID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridViewTransactions.DataSource = table;

            db.closeConnection();
        }

        public void RefreshTransactionHistory()
        {
            LoadTransactionHistory();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxCurrencyExchange_Click(object sender, EventArgs e)
        {
            CurrencyExchange currencyExchange = new CurrencyExchange(loggedInUserID);
            currencyExchange.ShowDialog(); 
            RefreshTransactionHistory(); 
        }

        private void pictureBoxWallet_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet(loggedInUserID);
            wallet.ShowDialog(); 
            RefreshTransactionHistory(); 
        }

        private void pictureBoxMoneyTransfer_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.ShowDialog(); 
            RefreshTransactionHistory(); 
        }
    }
}
