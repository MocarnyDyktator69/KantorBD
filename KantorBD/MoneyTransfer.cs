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

namespace KantorBD
{
    public partial class MoneyTransfer : Form
    {
        private DB db = new DB();
        private int loggedInUserID;

        private ComboBox comboBoxBankAccounts;
        private TextBox textBoxTransferAmount;


        public MoneyTransfer()
        {
            InitializeComponent();
        }
        public MoneyTransfer(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
        }
        public MoneyTransfer(ComboBox comboBox)
        {
            InitializeComponent();
            comboBoxBankAccounts = comboBox;
        }

        public MoneyTransfer(object sender, EventArgs e)
        {
            InitializeComponent();
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
        private bool TransferFromBankAccountToWallet(int bankAccountId, decimal amount, string creditCardNumber)
        {
            // Dodaj logikę przelewu, w tym sprawdzenie numeru karty kredytowej
            // Możesz wykorzystać dodatkowe walidacje lub integracje z systemem obsługi płatności
            // Na potrzeby tego przykładu, dodajemy tylko podstawową logikę przelewu
            int walletID = GetUserWalletID(loggedInUserID);

            using (DB db = new DB())
            {
                db.openConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    // Rozpocznij transakcję
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Pobierz saldo i wykonaj sprawdzenie dostępności środków
                            string selectBankAccountQuery = "SELECT balance FROM bankaccount WHERE accountID = @accountID";
                            MySqlCommand selectBankAccountCommand = new MySqlCommand(selectBankAccountQuery, connection, transaction);
                            selectBankAccountCommand.Parameters.AddWithValue("@accountID", bankAccountId);

                            decimal bankAccountBalance = Convert.ToDecimal(selectBankAccountCommand.ExecuteScalar());

                            if (bankAccountBalance < amount)
                            {
                                // Brak wystarczających środków na koncie bankowym
                                transaction.Rollback();
                                return false;
                            }

                            // Przetwarzanie przelewu...

                            // Zatwierdź transakcję
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            // Wystąpił błąd, cofnij transakcję
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
            // Pobierz numer karty kredytowej
            string creditCardNumber = txtCreditCardNumber.Text;

            // Pobierz wybrane konto bankowe i kwotę
            int bankAccountId = Convert.ToInt32(comboBoxBankAccounts.SelectedValue);
            decimal transferAmount = Convert.ToDecimal(textBoxTransferAmount.Text);

            // Wywołaj metodę dokonującą przelewu
            bool success = TransferFromBankAccountToWallet(bankAccountId, transferAmount, creditCardNumber);

            if (success)
            {
                MessageBox.Show("Przelew zakończony pomyślnie.");
                // Załaduj ponownie dane portfela po wykonaniu przelewu
            }
            else
            {
                MessageBox.Show("Nie udało się dokonać przelewu. Sprawdź dostępne środki na koncie.");
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
