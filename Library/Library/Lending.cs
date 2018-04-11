using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library
{
        public class Lending
        {
            private string name;
            public Lending() { }
            public Lending(string name)
            {
                this.name = name;
            }
            public int LendingID { get; set; }
            public string Name { get { return name; } set { name = value; } }
        }
}
