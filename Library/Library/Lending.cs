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
            private library lib;
            public Lending() { }
            public Lending(string status_name, library lib)
            {
                name = status_name;
                this.lib = lib;
            }
            public int LendingID { get; set; }
            public int LibraryID { get; set; }
            public string Name { get { return name; } set { name = value; } }
            [ForeignKey("LibraryID")]
            public library library { get { return lib; } }
        }
}
