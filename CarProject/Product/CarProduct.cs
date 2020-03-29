using System;
using System.Collections.Generic;

namespace CarProject
{
    public class CarProduct
    {
        private string _CarType;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public CarProduct(string carType)
        {
            _CarType = carType;
        }

        //indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void showCar()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _CarType);
            foreach (KeyValuePair<string, string> item in _parts)
            {
                Console.WriteLine($" {item.Key} : {item.Value}");
            }
        }
    }
}
