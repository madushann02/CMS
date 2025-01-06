using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Person
    {
        private string name;
        private string contact_number;
        private int id;

        public Person(string name, string contact_number, int id)
        {
            Name = name;
            Contact_number = contact_number;
            Id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Contact_number { get => contact_number; set => contact_number = value; }
        public int Id { get => id; set => id = value; }


    }
}
