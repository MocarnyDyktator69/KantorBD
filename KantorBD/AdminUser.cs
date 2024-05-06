using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KantorBD
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable table = new DataTable();
        int userIndex = 0;

        public void getUsers()
        {
            table.Clear();
            dataGridViewUser.DataSource = table;

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT U.*, UT.type FROM `User` AS U JOIN `Usertype` AS UT ON U.usertypeID = UT.usertypeID;", db.getConnection());
            adapter.Fill(table);
            dataGridViewUser.DataSource = table;

            labelUserI.Text = table.Rows.Count.ToString() + " User";
        }
        private void AdminUser_Load(object sender, EventArgs e)
        {
            getUsers();

            dataGridViewUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 9, 48);
            dataGridViewUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 193, 37);
            dataGridViewUser.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 13, FontStyle.Bold);
            dataGridViewUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewUser.EnableHeadersVisualStyles = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm f5 = new StartForm();
            f5.Show();
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

        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewUser.CurrentRow;

            numericID.Value = int.Parse(selectedRow.Cells[0].Value.ToString());
            textBoxName.Text = selectedRow.Cells[1].Value.ToString();
            textBoxSurname.Text = selectedRow.Cells[2].Value.ToString();
            textBoxEmail.Text = selectedRow.Cells[3].Value.ToString();
            textBoxBirth.Text = selectedRow.Cells[5].Value.ToString();
            comboBoxUserTypeId.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericID.Value;
                DataRow[] row = table.Select("userID = " + id);
                if (row.Length > 0)
                {
                    textBoxName.Text = row[0][1].ToString();
                    textBoxSurname.Text = row[0][2].ToString();
                    textBoxEmail.Text = row[0][3].ToString();
                    textBoxBirth.Text = row[0][5].ToString();
                    comboBoxUserTypeId.Text = row[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("User not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxEmail.Text = "";
                    textBoxBirth.Text = "";
                    comboBoxUserTypeId.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = (int)numericID.Value;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string usertypeID = comboBoxUserTypeId.Text;

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `name`=@nm, `surname`=@sn, `email`=@em, `usertypeID`= @typ WHERE `userID` = @id", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = usertypeID;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                getUsers();
                MessageBox.Show("User data updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = (int)numericID.Value;

            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `userID` = @id", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                numericID.Value = 0;
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxEmail.Text = "";
                textBoxBirth.Text = "";
                comboBoxUserTypeId.SelectedIndex = 0;
                getUsers();
                MessageBox.Show("User deleted", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            userIndex = 0;
            displayInfo(userIndex);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            userIndex--;
            if (userIndex < 0)
            {
                userIndex = 0;
            }
            displayInfo(userIndex);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            userIndex++;
            if (userIndex >= table.Rows.Count)
            {
                userIndex = table.Rows.Count - 1;
            }
            displayInfo(userIndex);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            userIndex = table.Rows.Count - 1;
            displayInfo(userIndex);
        }

        public void displayInfo(int index)
        {
            dataGridViewUser.ClearSelection();
            dataGridViewUser.Rows[index].Selected = true;

            numericID.Value = (int)table.Rows[index][0];
            textBoxName.Text = table.Rows[index][1].ToString();
            textBoxSurname.Text = table.Rows[index][2].ToString();
            textBoxEmail.Text = table.Rows[index][3].ToString();
            textBoxBirth.Text = table.Rows[index][5].ToString();
            comboBoxUserTypeId.Text = table.Rows[index][6].ToString();


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericID.Value = 0;
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxBirth.Text = "";
            comboBoxUserTypeId.SelectedIndex = 0;
        }
    }
}
