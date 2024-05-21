using KantorBD;
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
            RefreshTransactionHistory();
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
