﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author:Person
    {
        private DateTime death_date;
        private Country country;

        public Country Country { get { return country; } set { country = value; } }
        public DateTime Death_date { get { return death_date; } set { death_date = value; } }

        public Author():base() { }
        public Author(string fname, string sname, string mname, DateTime birthdate, DateTime death_date, Country country):base(fname, sname, mname, birthdate)
        {
            this.death_date = death_date;
            this.country = country;
        }
    }
}
