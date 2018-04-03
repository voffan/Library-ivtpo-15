using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
        public class Lending
        {
            private string name;
            private library lib;
            public Lending() { }
            public Lending(string status_name, library lib)
            {
                name = status_name;
                this.lib = lib;
            }
            public string Name { get { return name; } set { name = value; } }
            public library LIBRARY { get { return lib; } }
        }
}
