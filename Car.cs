using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Car
    {
        private int id;
        private string model;
        private string plate_number;
        private bool is_available;

        public Car(int id, string model, string plate_number)
        {
            Id = id;
            Model = model;
            Plate_number = plate_number;
            Is_available = true;
        }

        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Plate_number { get => plate_number; set => plate_number = value; }
        public bool Is_available { get => is_available; set => is_available = value; }
    }
}
