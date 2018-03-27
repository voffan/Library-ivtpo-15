using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Country
    {
        private string name;
        public Country() { }
        public Country(string country_name) 
        {
            name = country_name;
        }
        public string Name { get { return name; } set { name = value; } }
    }
}
