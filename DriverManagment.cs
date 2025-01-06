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
    public partial class DriverManagment : Form
    {
        public DriverManagment()
        {
            InitializeComponent();
        }

        private void DriverManagment_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            dataGridView1.DataSource = admin.view_drivers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string contact_number = textBox3.Text;

            Driver driver = new Driver(name, contact_number, id);
            Admin admin = new Admin();
            admin.add_driver(driver);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            DriverManagment_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            Admin admin = new Admin();
            admin.delete_driver(id);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            DriverManagment_Load(sender, e);
        }
    }
}
