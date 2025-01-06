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
    public partial class Signu_ : Form
    {
        public Signu_()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;
            string pick = textBox3.Text;
            string drop = textBox4.Text;
            string contact = textBox5.Text;

            Customer customer = new Customer(uname,contact,0,pick,drop,pass);
            customer.CreateProfile(customer);

            this.Hide();
            new Login().Show();
        }
    }
}
