using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Position
    {
        private string name;

        public Position(){}
        public Position(string position_name)
        {
            name = position_name;
        }
        public string Name { get { return name; } set { name = value; } }
    }
}
