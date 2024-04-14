using Connection_DB;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KantorBD
{
    public partial class Form2 : Form
    {
        connection con = new connection();
        string id, email, password, firstname, lastname;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Box1email = textBox1.Text;
            string Box2password = textBox2.Text;

            try
            {
                if (Box1email != "" && Box2password != "")
                {
                    con.Open();
                    string query = "select id,username,password,firstname,lastname,address from user WHERE username ='" + Box1email + "' AND password ='" + Box2password + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            email = row["username"].ToString();
                            password = row["password"].ToString();
                            firstname = row["firstname"].ToString();
                            lastname = row["lastname"].ToString();
                        }
                        MessageBox.Show("Data found, your name is " + firstname + " " + lastname);
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}
