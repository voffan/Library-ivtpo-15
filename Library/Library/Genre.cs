﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Genre
    {
        private string name;
        public Genre(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } set { name = value; } }
    }
}
