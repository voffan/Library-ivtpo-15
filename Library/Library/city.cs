using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class City
    {
        [Required]
        private string name;
        [Required]
        private Country country;

        public City() { }
        public City(string city_name, Country city_country)
        {
            name = city_name;
            country = city_country;
        }
        public int CityID { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public Country Country { get { return country; } set { country = value; } }
        public int CountryID { get; set; }
    }
}
