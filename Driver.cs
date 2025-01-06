using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Driver : Person
    {
        private bool is_available;

        public Driver(string name, string contact_number, int id) : base(name, contact_number, id)
        {
            Is_available = true;
        }

        public bool Is_available { get => is_available; set => is_available = value; }
    }
}
