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
    public partial class CarManagment : Form
    {
        public CarManagment()
        {
            InitializeComponent();
        }

        private void CarManagment_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            dataGridView1.DataSource = admin.view_cars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string model = textBox2.Text;
            string plate_number = textBox3.Text;
            Car car = new Car(id, model, plate_number);
            Admin admin = new Admin();
            admin.add_car(car);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            CarManagment_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            Admin admin = new Admin();
            admin.delete_car(id);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            CarManagment_Load(sender, e);
        }
    }
}
