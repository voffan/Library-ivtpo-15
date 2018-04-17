using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Publisher
    {
        public Publisher() { }
        public Publisher(string publisher_name) 
        {
            Name = publisher_name;
        }
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
    }
}
