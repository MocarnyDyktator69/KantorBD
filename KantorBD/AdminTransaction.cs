using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace KantorBD
{
    public partial class AdminTransaction : Form
    {
        public AdminTransaction()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(2000, 1, 1);
        }

        DB db = new DB();
        BindingList<TransactionDTO> transactions = new BindingList<TransactionDTO>();
        int transactionID = 0;

        public BindingList<TransactionDTO> getTransactions()
        {
            transactions.Clear();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT T.*, U.email AS user_email, C1.currencyCode AS from_currency_code, C2.currencyCode AS to_currency_code, DATE(T.transactionDate) AS transactionsDate FROM Transactions AS T JOIN User AS U ON T.userID = U.userID JOIN Wallet AS W ON T.walletID = W.walletID JOIN Currency AS C1 ON T.fromCurrencyID = C1.currencyID JOIN Currency AS C2 ON T.toCurrencyID = C2.currencyID ORDER BY T.transactionDate DESC;", db.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                TransactionDTO transaction = new TransactionDTO()
                {
                    TransactionID = row["transactionID"] == DBNull.Value ? 0 : int.TryParse(row["transactionID"].ToString(), out int transactionID) ? transactionID : 0,
                    UserEmail = row["user_email"] == DBNull.Value ? null : row["user_email"].ToString(),
                    WalletID = row["walletID"] == DBNull.Value ? 0 : int.TryParse(row["walletID"].ToString(), out int walletID) ? walletID : 0,
                    FromCurrencyCode = row["from_currency_code"] == DBNull.Value ? null : row["from_currency_code"].ToString(),
                    ToCurrencyCode = row["to_currency_code"] == DBNull.Value ? null : row["to_currency_code"].ToString(),
                    Amount = row["amount"] == DBNull.Value ? 0 : decimal.TryParse(row["amount"].ToString(), out decimal amount) ? amount : 0,
                    ExchangeRate = row["exchangeRate"] == DBNull.Value ? 0 : decimal.TryParse(row["exchangeRate"].ToString(), out decimal exchangeRate) ? exchangeRate : 0,
                    TransactionsType = row["transactionType"] == DBNull.Value ? null : row["transactionType"].ToString(),
                    TransactionsDate = row["transactionsDate"] == DBNull.Value ? DateTime.MinValue : DateTime.TryParse(row["transactionsDate"].ToString(), out DateTime transactionsDate) ? transactionsDate : DateTime.MinValue
                };

                transactions.Add(transaction);
            }

            listViewTransaction.Items.Clear();
            foreach (TransactionDTO transaction in transactions)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionID.ToString());
                item.SubItems.Add(transaction.UserEmail);
                item.SubItems.Add(transaction.WalletID.ToString());
                item.SubItems.Add(transaction.FromCurrencyCode);
                item.SubItems.Add(transaction.ToCurrencyCode);
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.ExchangeRate.ToString());
                item.SubItems.Add(transaction.TransactionsType);
                item.SubItems.Add(transaction.TransactionsDate.ToString("dd.MM.yyyy"));
                item.Tag = transaction;
                listViewTransaction.Items.Add(item);
            }

            labelTransactionI.Text = transactions.Count.ToString() + " Transactions";

            return transactions;
        }

        private void AdminTransaction_Load(object sender, EventArgs e)
        {
            getTransactions();

            listViewTransaction.View = View.Details;
            listViewTransaction.FullRowSelect = true;
            listViewTransaction.GridLines = true;
            listViewTransaction.Columns.Add("ID", 50);
            listViewTransaction.Columns.Add("Email", 200);
            listViewTransaction.Columns.Add("Wallet ID", 100);
            listViewTransaction.Columns.Add("From Currency", 100);
            listViewTransaction.Columns.Add("To Currency", 100);
            listViewTransaction.Columns.Add("Amount", 100);
            listViewTransaction.Columns.Add("Exchange Rate", 100);
            listViewTransaction.Columns.Add("Type", 100);
            listViewTransaction.Columns.Add("Date", 100);

            listViewTransaction.Columns[0].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[2].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[3].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[4].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[5].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[6].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[7].TextAlign = HorizontalAlignment.Center;
            listViewTransaction.Columns[8].TextAlign = HorizontalAlignment.Center;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdminForm f6 = new MainAdminForm();
            f6.Show();
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            dateTimePicker1.Value = new DateTime(2000, 1, 1);
            listViewTransaction.Items.Clear();
            foreach (TransactionDTO transaction in transactions)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionID.ToString());
                item.SubItems.Add(transaction.UserEmail);
                item.SubItems.Add(transaction.WalletID.ToString());
                item.SubItems.Add(transaction.FromCurrencyCode);
                item.SubItems.Add(transaction.ToCurrencyCode);
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.ExchangeRate.ToString());
                item.SubItems.Add(transaction.TransactionsType);
                item.SubItems.Add(transaction.TransactionsDate.ToString("dd.MM.yyyy"));
                item.Tag = transaction;
                listViewTransaction.Items.Add(item);
            }
            labelTransactionI.Text = transactions.Count.ToString() + " Transactions";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBoxEmail.Text;
                DateTime date = dateTimePicker1.Value.Date;

                List<TransactionDTO> filteredTransactions;

                // Sprawdzamy, czy użytkownik podał email, datę lub oba
                if (string.IsNullOrWhiteSpace(email) && date == new DateTime(2000, 1, 1))
                {
                    // Jeśli nie podał żadnego z nich, wyświetlamy wszystkie transakcje
                    filteredTransactions = new List<TransactionDTO>();
                }
                else if (string.IsNullOrWhiteSpace(email))
                {
                    // Jeśli nie podał email, wyszukujemy tylko po dacie
                    filteredTransactions = transactions.Where(t => t.TransactionsDate.Date == date).ToList();
                }
                else if (date == new DateTime(2000, 1, 1))
                {
                    // Jeśli nie podał daty, wyszukujemy tylko po email
                    filteredTransactions = transactions.Where(t => t.UserEmail.Contains(email)).ToList();
                }
                else
                {
                    // Jeśli podał oba, wyszukujemy po email i dacie
                    filteredTransactions = transactions.Where(t => t.UserEmail.Contains(email) && t.TransactionsDate.Date == date).ToList();
                }

                if (filteredTransactions.Count > 0)
                {
                    listViewTransaction.Items.Clear();
                    foreach (TransactionDTO transaction in filteredTransactions)
                    {
                        ListViewItem item = new ListViewItem(transaction.TransactionID.ToString());
                        item.SubItems.Add(transaction.UserEmail);
                        item.SubItems.Add(transaction.WalletID.ToString());
                        item.SubItems.Add(transaction.FromCurrencyCode);
                        item.SubItems.Add(transaction.ToCurrencyCode);
                        item.SubItems.Add(transaction.Amount.ToString());
                        item.SubItems.Add(transaction.ExchangeRate.ToString());
                        item.SubItems.Add(transaction.TransactionsType);
                        item.SubItems.Add(transaction.TransactionsDate.ToString("dd.MM.yyyy"));
                        item.Tag = transaction;
                        listViewTransaction.Items.Add(item);
                    }
                    labelTransactionI.Text = filteredTransactions.Count.ToString() + " Transactions";
                }
                else
                {
                    MessageBox.Show("No transactions found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.Items.Count > 0)
            {
                listViewTransaction.Items[transactionID].Selected = false;
                transactionID = 0;
                listViewTransaction.Items[transactionID].Selected = true;
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.Items.Count > 0)
            {
                listViewTransaction.Items[transactionID].Selected = false;
                transactionID--;
                if (transactionID < 0)
                {
                    transactionID = 0;
                }
                listViewTransaction.Items[transactionID].Selected = true;
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.Items.Count > 0)
            {
                listViewTransaction.Items[transactionID].Selected = false;
                transactionID++;
                if (transactionID >= listViewTransaction.Items.Count)
                {
                    transactionID = listViewTransaction.Items.Count - 1;
                }
                listViewTransaction.Items[transactionID].Selected = true;
            }

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.Items.Count > 0)
            {
                listViewTransaction.Items[transactionID].Selected = false;
                transactionID = listViewTransaction.Items.Count - 1;
                listViewTransaction.Items[transactionID].Selected = true;
            }

        }

        
    }

    public class TransactionDTO
    {
        public int TransactionID { get; set; }
        public string UserEmail { get; set; }
        public int WalletID { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal ExchangeRate { get; set; }
        public string TransactionsType { get; set; }
        public DateTime TransactionsDate { get; set; }
    }

}
