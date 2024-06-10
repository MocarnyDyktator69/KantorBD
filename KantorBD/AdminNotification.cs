using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KantorBD
{
    public partial class AdminNotification : Form
    {
        private readonly string connectionString;
        private ListView listViewNotifications;

        public AdminNotification()
        {
            InitializeComponent();
            this.connectionString = "server=localhost;port=3306;username=root;password=;database=kantor_db";

            listViewNotifications = new ListView();
            listViewNotifications.View = View.Details;
            listViewNotifications.FullRowSelect = true;
            listViewNotifications.Columns.Add("ID");
            listViewNotifications.Columns.Add("Tytuł");
            listViewNotifications.Columns.Add("Treść");
            listViewNotifications.Columns.Add("Data Rozpoczęcia");
            listViewNotifications.Columns.Add("Data Zakończenia");
            listViewNotifications.Columns.Add("Typ");
            listViewNotifications.SelectedIndexChanged += listViewNotifications_SelectedIndexChanged;

            listViewNotifications.Dock = DockStyle.Fill;

            listViewNotifi.Controls.Add(listViewNotifications);

            LoadNotifications();
        }

        private void LoadNotifications()
        {
            listViewNotifications.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, title, content, start_date, end_date, type FROM notifications";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["title"].ToString());
                        item.SubItems.Add(reader["content"].ToString());
                        item.SubItems.Add(reader["start_date"].ToString());
                        item.SubItems.Add(reader["end_date"].ToString());
                        item.SubItems.Add(reader["type"].ToString());
                        listViewNotifications.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania powiadomień: " + ex.Message);
                }
            }
        }

        private void listViewNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNotifications.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewNotifications.SelectedItems[0];

                textTitleNotifiBox.Text = selectedItem.SubItems[1].Text;
                textTextNotifiBox.Text = selectedItem.SubItems[2].Text;
                dateTimePickerStartNotifi.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                dateTimePickerEndNotifi.Value = DateTime.Parse(selectedItem.SubItems[4].Text);
            }
        }

        private void buttonAddNotifi_Click(object sender, EventArgs e)
        {
            string title = textTitleNotifiBox.Text;
            string content = textTextNotifiBox.Text;
            DateTime startDate = dateTimePickerStartNotifi.Value;
            DateTime endDate = dateTimePickerEndNotifi.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO notifications (title, content, start_date, end_date) VALUES (@title, @content, @start_date, @end_date)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@start_date", startDate);
                    cmd.Parameters.AddWithValue("@end_date", endDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nowe powiadomienie zostało dodane.");
                    ClearFields();
                    LoadNotifications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas dodawania powiadomienia: " + ex.Message);
                }
            }
        }

        private void buttonUpdateNotifi_Click(object sender, EventArgs e)
        {
            if (listViewNotifications.SelectedItems.Count > 0)
            {
                int notificationId = Convert.ToInt32(listViewNotifications.SelectedItems[0].Text);

                string title = textTitleNotifiBox.Text;
                string content = textTextNotifiBox.Text;
                DateTime startDate = dateTimePickerStartNotifi.Value;
                DateTime endDate = dateTimePickerEndNotifi.Value;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE notifications SET title = @title, content = @content, start_date = @start_date, end_date = @end_date WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@content", content);
                        cmd.Parameters.AddWithValue("@start_date", startDate);
                        cmd.Parameters.AddWithValue("@end_date", endDate);
                        cmd.Parameters.AddWithValue("@id", notificationId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Powiadomienie zostało zaktualizowane.");
                        ClearFields();
                        LoadNotifications();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas aktualizowania powiadomienia: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz powiadomienie do zaktualizowania.");
            }
        }

        private void buttonDelNotifi_Click(object sender, EventArgs e)
        {
            if (listViewNotifications.SelectedItems.Count > 0)
            {
                int notificationId = Convert.ToInt32(listViewNotifications.SelectedItems[0].Text);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM notifications WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", notificationId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Powiadomienie zostało usunięte.");
                        ClearFields();
                        LoadNotifications();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas usuwania powiadomienia: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz powiadomienie do usunięcia.");
            }
        }

        private void ClearFields()
        {
            textTitleNotifiBox.Text = "";
            textTextNotifiBox.Text = "";
            dateTimePickerStartNotifi.Value = DateTime.Now;
            dateTimePickerEndNotifi.Value = DateTime.Now;
        }

        private void textTitleNotifiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTextNotifiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartNotifi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndNotifi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdminForm mainAdminForm = new MainAdminForm();
            mainAdminForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminUser mainAdminForm = new AdminUser();
            mainAdminForm.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWalletcs adminWalletcs = new AdminWalletcs();
            adminWalletcs.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                AdminSettings adminSettings = new AdminSettings();
                adminSettings.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm f5 = new StartForm();
            f5.Show();
        }
    }
}
