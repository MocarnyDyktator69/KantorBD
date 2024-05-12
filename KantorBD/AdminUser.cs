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
        BindingList<UserDTO> users = new BindingList<UserDTO>();
        int userIndex = 0;

        public BindingList<UserDTO> getUsers()
        {
            users.Clear();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT U.*, UT.type FROM `User` AS U JOIN `Usertype` AS UT ON U.usertypeID = UT.usertypeID;", db.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                UserDTO user = new UserDTO
                {
                    UserID = row["userID"] == DBNull.Value ? 0 : int.TryParse(row["userID"].ToString(), out int userId) ? userId : 0,
                    FullName = row["name"].ToString() + " " + row["surname"].ToString(),
                    Name = row["name"] == DBNull.Value ? null : row["name"].ToString(),
                    Surname = row["surname"] == DBNull.Value ? null : row["surname"].ToString(),
                    Email = row["email"] == DBNull.Value ? null : row["email"].ToString(),
                    BirthDate = row["birth_date"] == DBNull.Value ? DateTime.MinValue : DateTime.TryParse(row["birth_date"].ToString(), out DateTime birthdate) ? birthdate : DateTime.MinValue,
                    Type = row["type"] == DBNull.Value ? null : row["type"].ToString()
                };
                users.Add(user);
            }


            listViewUser.Items.Clear();
            foreach (UserDTO user in users)
            {
                ListViewItem item = new ListViewItem(user.UserID.ToString());
                item.SubItems.Add(user.FullName);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.BirthDate.ToString("dd.MM.yyyy"));
                item.SubItems.Add(user.Type);
                item.Tag = user;
                listViewUser.Items.Add(item);
            }

            labelUserI.Text = users.Count.ToString() + " User";

            return users;

        }
        private void AdminUser_Load(object sender, EventArgs e)
        {
            getUsers();

            listViewUser.View = View.Details;
            listViewUser.FullRowSelect = true;
            listViewUser.GridLines = true;
            listViewUser.Columns.Add("ID", 50);
            listViewUser.Columns.Add("Name and Surname", 200);
            listViewUser.Columns.Add("Email", 200);
            listViewUser.Columns.Add("Birth_date", 150);
            listViewUser.Columns.Add("Type", 75);

            listViewUser.Columns[0].TextAlign = HorizontalAlignment.Center;
            listViewUser.Columns[1].TextAlign = HorizontalAlignment.Center;
            listViewUser.Columns[2].TextAlign = HorizontalAlignment.Center;
            listViewUser.Columns[3].TextAlign = HorizontalAlignment.Center;
            listViewUser.Columns[4].TextAlign = HorizontalAlignment.Center;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBoxEmail.Text;
                UserDTO user = users.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    numericID.Value = user.UserID;
                    textBoxName.Text = user.Name;
                    textBoxSurname.Text = user.Surname;
                    textBoxBirth.Text = user.BirthDate.ToString("yyyy-MM-dd");
                    comboBoxUserTypeId.Text = user.Type;
                }
                else
                {
                    MessageBox.Show("User not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericID.Value = 0;
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
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
            string birth = textBoxBirth.Text;
            string usertypeID = comboBoxUserTypeId.Text;

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `name`=@nm, `surname`=@sn, `email`=@em, `birth_date`=@bi, `usertypeID`= @typ WHERE `userID` = @id", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@bi", MySqlDbType.VarChar).Value = birth;
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
            if (userIndex >= users.Count)
            {
                userIndex = users.Count - 1;
            }
            displayInfo(userIndex);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            userIndex = users.Count - 1;
            displayInfo(userIndex);
        }

        public void displayInfo(int index)
        {
            UserDTO selectedUser = users[index];

            numericID.Value = selectedUser.UserID;
            textBoxName.Text = selectedUser.Name;
            textBoxSurname.Text = selectedUser.Surname;
            textBoxEmail.Text = selectedUser.Email;
            textBoxBirth.Text = selectedUser.BirthDate.ToString("yyyy-MM-dd");
            comboBoxUserTypeId.Text = selectedUser.Type;

            listViewUser.SelectedIndices.Clear();
            listViewUser.SelectedIndices.Add(index);


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

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count > 0)
            {
                UserDTO selectedUser = (UserDTO)listViewUser.SelectedItems[0].Tag;

                numericID.Value = selectedUser.UserID;
                textBoxName.Text = selectedUser.Name;
                textBoxSurname.Text = selectedUser.Surname;
                textBoxEmail.Text = selectedUser.Email;
                textBoxBirth.Text = selectedUser.BirthDate.ToString("yyyy-MM-dd");
                comboBoxUserTypeId.Text = selectedUser.Type;
            }

        }

        private void textBoxBirth_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class UserDTO
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Type { get; set; }

    }

}
