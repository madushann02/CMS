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

namespace Madu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            if (uname == "" || pass == "")
            {
                MessageBox.Show("Please fill all fields");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                if (uname == "admin" && pass == "admin")
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    new AdminDashboard().Show();
                }
                else
                {
                    try
                    {
                        string query = "select * from customers where name = '" + uname + "' and password = '" + pass + "'";
                        ConnectionString conn = new ConnectionString();
                        MySqlConnection connection = new MySqlConnection(conn.Database);
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            new CustomerDashboard(uname).Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                            textBox1.Clear();
                            textBox2.Clear();
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invalid Username or Password");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Signu_().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
