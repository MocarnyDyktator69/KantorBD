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
    public partial class AdminWalletcs : Form
    {
        public AdminWalletcs()
        {
            InitializeComponent();
        }

        DB db = new DB();
        BindingList<WalletDTO> wallets = new BindingList<WalletDTO>();
        int walletID = 0;
        private HashSet<string> currencyColumns = new HashSet<string>();

        public BindingList<WalletDTO> getWallets()
        {
            wallets.Clear();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT W.*, WC.*, U.email AS user_email, C.currencyCode AS currency_code, C.currencyName AS currency_name FROM Wallet AS W JOIN User AS U ON W.userID = U.userID JOIN WalletCurrency AS WC ON W.walletID = WC.walletID JOIN Currency AS C ON WC.currencyID = C.currencyID;", db.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);

            var walletGroups = table.AsEnumerable()
                .GroupBy(row => new { userID = row["userID"], email = row["user_email"] });

            foreach (var walletGroup in walletGroups)
            {
                WalletDTO wallet = new WalletDTO()
                {
                    WalletID = walletGroup.Key.userID == DBNull.Value ? 0 : int.TryParse(walletGroup.Key.userID.ToString(), out int walletID) ? walletID : 0,
                    Email = walletGroup.Key.email == DBNull.Value ? null : walletGroup.Key.email.ToString(),
                };

                foreach (DataRow row in walletGroup)
                {
                    string currencyCode = row["currency_code"] == DBNull.Value ? null : row["currency_code"].ToString();
                    decimal balance = row["balance"] == DBNull.Value ? 0 : decimal.TryParse(row["balance"].ToString(), out decimal balanceValue) ? balanceValue : 0;
                    string currencyName = row["currency_name"] == DBNull.Value ? null : row["currency_name"].ToString();

                    if (wallet.Currencies.ContainsKey(currencyCode))
                    {
                        wallet.Currencies[currencyCode] += balance;
                    }
                    else
                    {
                        wallet.Currencies.Add(currencyCode, balance);
                    }

                    if (currencyCode != DBNull.Value.ToString() && !currencyColumns.Contains(currencyCode))
                    {
                        currencyColumns.Add(currencyCode);
                        listViewWallet.Columns.Add(currencyCode, 100, HorizontalAlignment.Center);
                    }
                }

                wallets.Add(wallet);
            }

            listViewWallet.Items.Clear();
            foreach (WalletDTO wallet in wallets)
            {
                ListViewItem item = new ListViewItem(wallet.Email);
                item.SubItems.Add(wallet.WalletID.ToString());

                int currencyColumnIndex = 2;
                foreach (var currency in wallet.Currencies)
                {
                    item.SubItems.Add(currency.Value.ToString());
                    currencyColumnIndex++;
                }

                item.Tag = wallet;
                listViewWallet.Items.Add(item);
            }

            labelWalletI.Text = wallets.Count.ToString() + " Wallets";

            return wallets;
        }

        private void AdminWalletcs_Load(object sender, EventArgs e)
        {
            listViewWallet.View = View.Details;
            listViewWallet.FullRowSelect = true;
            listViewWallet.GridLines = true;
            listViewWallet.Columns.Add("Email", 200);
            listViewWallet.Columns.Add("ID", 50);

            listViewWallet.Columns[0].TextAlign = HorizontalAlignment.Center;
            listViewWallet.Columns[1].TextAlign = HorizontalAlignment.Center;

            getWallets();

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
        
    }

    public class WalletDTO
    {
        public int WalletID { get; set; }
        public string Email { get; set; }
        public Dictionary<string, decimal> Currencies { get; set; }

        public WalletDTO()
        {
            Currencies = new Dictionary<string, decimal>();
        }
    }

}
