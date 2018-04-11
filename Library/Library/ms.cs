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
        public Person (string Person_fname, string Person_sname, string Person_mname, DateTime Person_birthdate)
        {
            fname = Person_fname;
            sname = Person_sname;
            mname = Person_mname;
            SetFullName();
            birthdate = Person_birthdate;
        }
        private void SetFullName()
        {
            fullname = fname + " " + sname + " " + mname;
        }
        public int PersonID { get; set; }
        public string FirstName { get { return fname; } set { fname = value; SetFullName(); } }
        public string LastName { get { return sname; } set { sname = value; SetFullName(); } }
        public string MiddleName { get { return mname; } set { mname = value; SetFullName(); } }
        public string FullName { get { return fullname; } }
        public DateTime Birthday { get { return birthdate; } set { birthdate = value; } }
    }
}
