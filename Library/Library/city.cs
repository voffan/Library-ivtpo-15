using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class City
    {
        private string name;
        private Country country;

        public City() { }
        public City(string city_name, Country city_country)
        {
            name = city_name;
            country = city_country;
        }
        public string Name { get { return name; } set { name = value; } }
        public Country Country { get { return country; } set { country = value; } }
    }
}
