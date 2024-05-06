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
    }
}
