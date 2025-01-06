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
    public partial class OrderCab : Form
    {
        private string username;
        public OrderCab(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void OrderCab_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            List<Car> cars = admin.view_available_cars();
            List<Driver> drivers = admin.view_available_drivers();

            // Bind the ComboBox
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";

            // Add each car to the ComboBox as KeyValuePair
            foreach (Car car in cars)
            {
                comboBox1.Items.Add(new KeyValuePair<string, int>(car.Model, car.Id));
            }
            foreach (Driver driver in drivers)
            {
                comboBox2.Items.Add(new KeyValuePair<string, int>(driver.Name, driver.Id));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            int car_id = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;
            int driver_id = ((KeyValuePair<string, int>)comboBox2.SelectedItem).Value;

            Admin admin = new Admin();

            Customer customer = admin.CustomerDetailsFromName(username);
            Driver driver = admin.get_driver_details_by_id(driver_id);
            Car car = admin.get_car_details_by_id(car_id);



            Order order = new Order(0, customer, driver,car, dateTime);

            admin.PlaceOrder(order);
        }
    }
}
