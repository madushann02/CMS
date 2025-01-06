using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Order
    {
        private int id;
        private Customer customer;
        private Driver driver;
        private Car car;
        private DateTime date;

        public Order(int id, Customer customer, Driver driver, Car car, DateTime date)
        {
            Id = id;
            Customer = customer;
            Driver = driver;
            Car = car;
            Date = date;
        }

        public int Id { get => id; set => id = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Car Car { get => car; set => car = value; }

        public DateTime Date { get => date; set => date = value; }
    }
}
