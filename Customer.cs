using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Customer : Person
    {
        private string current_location;
        private string destination;
        private string password;

        public Customer(string name, string contact_number, int id, string current_location, string destination, string password) : base(name, contact_number, id)
        {
            Current_location = current_location;
            Destination = destination;
            Password = password;
        }

        public string Current_location { get => current_location; set => current_location = value; }
        public string Destination { get => destination; set => destination = value; }

        public string Password { get => password; set => password = value; }

        public void CreateProfile(Customer customer)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "INSERT INTO Customers (name, contact_number, current_location, destination, password) VALUES (@name, @contact_number, @current_location, @destination, @password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@contact_number", customer.Contact_number);
                command.Parameters.AddWithValue("@current_location", customer.Current_location);
                command.Parameters.AddWithValue("@destination", customer.Destination);
                command.Parameters.AddWithValue("@password", customer.Password);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Sign-up Succeeded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
