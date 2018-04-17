using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library
{
    class Librarian: Person
    {
        public int LibrarianID { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Librarian():base() { }
        public Librarian(string Person_fname, string Person_sname, string Person_mname, DateTime Person_birthdate, Position position, User user, string phone="", string address="")
            : base(Person_fname, Person_sname, Person_mname, Person_birthdate)
        {
            Position = position;
            User = user;
            Phone = phone;
            Address = address;
        }
    }
}
