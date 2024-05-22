using KantorBD;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class TransactionHistory : Form
    {
        private int loggedInUserID;

        public TransactionHistory(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            dateTimePicker1.Value = new DateTime(2000, 1, 1);
        }

        DB db = new DB();
        BindingList<TransactionUserDTO> transactionsuser = new BindingList<TransactionUserDTO>();
        int transactionID = 0;

        public BindingList<TransactionUserDTO> getTransactionsUser()
        {
            transactionsuser.Clear();

            string query = "CALL GetTransactionsByUserID(@userID)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            adapter.SelectCommand.Parameters.AddWithValue("@userID", loggedInUserID);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                TransactionUserDTO transaction = new TransactionUserDTO()
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

                transactionsuser.Add(transaction);
            }

            listViewTransaction.Items.Clear();
            foreach (TransactionUserDTO transaction in transactionsuser)
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

            labelTransactionI.Text = transactionsuser.Count.ToString() + " Transactions";

            return transactionsuser;
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            getTransactionsUser();

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

            FillCurrencyCodes();
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

        private void FillCurrencyCodes()
        {
            string query = "CALL GetCurrencyCodes()";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);

            comboBoxCurrencyCodes.Items.Clear();
            comboBoxToCurrencyCodes.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                comboBoxCurrencyCodes.Items.Add(row["currencyCode"].ToString());
                comboBoxToCurrencyCodes.Items.Add(row["currencyCode"].ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string fromCurrencyCode = comboBoxCurrencyCodes.Text.Trim();
                string toCurrencyCode = comboBoxToCurrencyCodes.Text.Trim();
                DateTime date = dateTimePicker1.Value.Date;

                List<TransactionUserDTO> filteredTransactions;

                if (string.IsNullOrEmpty(fromCurrencyCode) && string.IsNullOrEmpty(toCurrencyCode) && date == new DateTime(2000, 1, 1))
                {
                    // Jeśli nie podano żadnego z nich, wyświetlamy wszystkie transakcje
                    filteredTransactions = new List<TransactionUserDTO>();
                }
                else if (string.IsNullOrEmpty(fromCurrencyCode) && string.IsNullOrEmpty(toCurrencyCode))
                {
                    // Jeśli nie podano walut, wyszukujemy tylko po dacie
                    filteredTransactions = transactionsuser.Where(t => t.TransactionsDate.Date == date).ToList();
                }
                else if (string.IsNullOrEmpty(fromCurrencyCode))
                {
                    // Jeśli nie podano waluty "od", wyszukujemy po walucie "do" i dacie
                    filteredTransactions = transactionsuser.Where(t => t.ToCurrencyCode.Contains(toCurrencyCode) && t.TransactionsDate.Date == date).ToList();
                }
                else if (string.IsNullOrEmpty(toCurrencyCode))
                {
                    // Jeśli nie podano waluty "do", wyszukujemy po walucie "od" i dacie
                    filteredTransactions = transactionsuser.Where(t => t.FromCurrencyCode.Contains(fromCurrencyCode) && t.TransactionsDate.Date == date).ToList();
                }
                else if (date == new DateTime(2000, 1, 1))
                {
                    // Jeśli nie podano daty, wyszukujemy po obu walutach
                    filteredTransactions = transactionsuser.Where(t => t.FromCurrencyCode.Contains(fromCurrencyCode) && t.ToCurrencyCode.Contains(toCurrencyCode)).ToList();
                }
                else
                {
                    // Jeśli podano wszystko, wyszukujemy po obu walutach i dacie
                    filteredTransactions = transactionsuser.Where(t => t.FromCurrencyCode.Contains(fromCurrencyCode) && t.ToCurrencyCode.Contains(toCurrencyCode) && t.TransactionsDate.Date == date).ToList();
                }

                if (filteredTransactions.Count > 0)
                {
                    listViewTransaction.Items.Clear();
                    foreach (TransactionUserDTO transaction in filteredTransactions)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxCurrencyCodes.SelectedIndex = -1;
            comboBoxToCurrencyCodes.SelectedIndex = -1;
            dateTimePicker1.Value = new DateTime(2000, 1, 1);
            listViewTransaction.Items.Clear();
            foreach (TransactionUserDTO transaction in transactionsuser)
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
            labelTransactionI.Text = transactionsuser.Count.ToString() + " Transactions";
        }
    }

    public class TransactionUserDTO
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
