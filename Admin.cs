using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madu
{
    internal class Admin
    {
        public DataTable view_cars()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Car";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void add_car(Car car)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "INSERT INTO Car (id, model, plate_number, is_available) VALUES (@id, @model, @plate_number, @is_available)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", car.Id);
                command.Parameters.AddWithValue("@model", car.Model);
                command.Parameters.AddWithValue("@plate_number", car.Plate_number);
                command.Parameters.AddWithValue("@is_available", car.Is_available);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Car added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_car(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "DELETE FROM Car WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Car deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable view_drivers()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Drivers";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void add_driver(Driver driver)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "INSERT INTO Drivers (id, name, contact_number, is_available) VALUES (@id, @name, @contact_number, @is_available)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", driver.Id);
                command.Parameters.AddWithValue("@name", driver.Name);
                command.Parameters.AddWithValue("@contact_number", driver.Contact_number);
                command.Parameters.AddWithValue("@is_available", driver.Is_available);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Driver added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_driver(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "DELETE FROM Drivers WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Driver deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable view_Orders()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Orders";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Car> view_available_cars()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Car WHERE is_available = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                List<Car> cars = new List<Car>();
                while (reader.Read())
                {
                    Car car = new Car( reader.GetInt32("id"), reader.GetString("model"), reader.GetString("plate_number"));
                    cars.Add(car);
                }
                connection.Close();
                return cars;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Driver> view_available_drivers()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Drivers WHERE is_available = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                List<Driver> drivers = new List<Driver>();
                while (reader.Read())
                {
                    Driver driver = new Driver( reader.GetString("name"), reader.GetString("contact_number"), reader.GetInt32("id"));
                    drivers.Add(driver);
                }
                connection.Close();
                return drivers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Customer CustomerDetailsFromName(string name)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Customers WHERE name = @name";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Customer customer = new Customer(reader.GetString("name"), reader.GetString("contact_number"), reader.GetInt32("id"), reader.GetString("current_location"), reader.GetString("destination"), reader.GetString("password")); 
                connection.Close();
                return customer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Driver get_driver_details_by_id(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Drivers WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Driver driver = new Driver(reader.GetString("name"), reader.GetString("contact_number"), reader.GetInt32("id"));
                connection.Close();
                return driver;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }  
        
        public Car get_car_details_by_id(int id) {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "SELECT * FROM Car WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Car car = new Car(reader.GetInt32("id"), reader.GetString("model"), reader.GetString("plate_number"));
                connection.Close();
                return car;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void PlaceOrder(Order order)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new ConnectionString().Database);
                connection.Open();
                string query = "INSERT INTO Orders (id, customer_id, driver_id, car_id, date) VALUES (@id, @customer_id, @driver_id, @car_id, @date)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", order.Id);
                command.Parameters.AddWithValue("@customer_id", order.Customer.Id);
                command.Parameters.AddWithValue("@driver_id", order.Driver.Id);
                command.Parameters.AddWithValue("@car_id", order.Car.Id);
                command.Parameters.AddWithValue("@date", order.Date);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Order placed successfully");
                //order Summary
                MessageBox.Show("Order Summary\n\nCustomer: " + order.Customer.Name + "\nDriver: " + order.Driver.Name + "\nCar: " + order.Car.Model + "\nDate: " + order.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   


    }
}
