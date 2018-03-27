using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
        private string fname;
        private string sname;
        private string mname;
        private string fullname;
        private DateTime birthdate;
        public Person() { }
        public Person (string Person_fname, string Person_sname, string Person_mname, string Person_fullname, DateTime Person_birthdate)
        {
            fname = Person_fname;
            sname = Person_sname;
            mname = Person_mname;
            fullname = Person_fullname;
            birthdate = Person_birthdate;
        }
    }
}
