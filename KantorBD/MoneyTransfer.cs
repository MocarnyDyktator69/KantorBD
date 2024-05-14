using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class MoneyTransfer : Form
    {
        private DB db = new DB();
        private int loggedInUserID;

        private int currencyID;


        public MoneyTransfer()
        {
            InitializeComponent();
        }
        public MoneyTransfer(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
        }

        private int GetUserWalletID(int userID)
        {
            int walletID = 0;
            using (DB db = new DB())
            {
                db.openConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    string query = "SELECT walletID FROM wallet WHERE userID = @userID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            walletID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            return walletID;
        }
        private bool TransferFromBankAccountToWallet(decimal amount)
        {
            int walletID = GetUserWalletID(loggedInUserID);

            using (DB db = new DB())
            {
                db.openConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string currencyQuery = "SELECT currencyID FROM currency WHERE currencyCode = 'PLN'";
                            MySqlCommand currencyCommand = new MySqlCommand(currencyQuery, connection, transaction);
                            object currencyResult = currencyCommand.ExecuteScalar();
                            if (currencyResult == null)
                            {
                                MessageBox.Show("Nie można znaleźć waluty PLN.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            int currencyID = Convert.ToInt32(currencyResult);

                            string updateWalletQuery = "UPDATE walletcurrency SET balance = balance + @amount WHERE walletID = @walletID AND currencyID = @currencyID";
                            MySqlCommand updateWalletCommand = new MySqlCommand(updateWalletQuery, connection, transaction);
                            updateWalletCommand.Parameters.AddWithValue("@amount", amount);
                            updateWalletCommand.Parameters.AddWithValue("@walletID", walletID);
                            updateWalletCommand.Parameters.AddWithValue("@currencyID", currencyID);
                            updateWalletCommand.ExecuteNonQuery();

                            string insertTransactionQuery = "INSERT INTO transactions (userID, walletID, fromCurrencyID, toCurrencyID, amount, transactionType, transactionDate) " +
                                                            "VALUES (@userID, @walletID, @fromCurrencyID, @toCurrencyID, @amount, @transactionType, @transactionDate)";
                            MySqlCommand insertTransactionCommand = new MySqlCommand(insertTransactionQuery, connection, transaction);
                            insertTransactionCommand.Parameters.AddWithValue("@userID", loggedInUserID);
                            insertTransactionCommand.Parameters.AddWithValue("@walletID", walletID);
                            insertTransactionCommand.Parameters.AddWithValue("@fromCurrencyID", currencyID);
                            insertTransactionCommand.Parameters.AddWithValue("@toCurrencyID", currencyID);
                            insertTransactionCommand.Parameters.AddWithValue("@amount", amount);
                            insertTransactionCommand.Parameters.AddWithValue("@transactionType", "transfer");
                            insertTransactionCommand.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                            insertTransactionCommand.ExecuteNonQuery();

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Wystąpił błąd podczas dokonywania przelewu: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
        }


        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            string transferAmountText = textBoxAmount.Text;
            string creditCardNumber = txtCreditCardNumber.Text;
            string cvv = textBoxCVV.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(transferAmountText) || string.IsNullOrWhiteSpace(creditCardNumber) ||
                string.IsNullOrWhiteSpace(cvv) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(transferAmountText, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Podaj poprawną kwotę przelewu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (creditCardNumber.Length != 16 || !creditCardNumber.All(char.IsDigit))
            {
                MessageBox.Show("Podaj poprawny numer karty kredytowej.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                MessageBox.Show("Podaj poprawny kod CVV.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = TransferFromBankAccountToWallet(transferAmount);

            if (success)
            {
                MessageBox.Show("Przelew zakończony pomyślnie.");
            }
            else
            {
                MessageBox.Show("Nie udało się dokonać przelewu. Sprawdź dostępne środki na koncie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void pictureBoxMoneyTransfer_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneytransfer = new MoneyTransfer(loggedInUserID);
            moneytransfer.Show();
            this.Hide();
        }
    }
}
