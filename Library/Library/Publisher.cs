using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Publisher
    {
        private string name;
        private City city;

        public Publisher() { }
        public Publisher(string publisher_name) 
        {
            name = publisher_name;
        }

        public string Name { get { return name; } set { name = value; } }
        public int CityID { get; set; }
        public City City { get { return city; } set { city = value; } }
        public int PublisherID { get; set; }
    }
}
