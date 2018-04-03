using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User {
        private string name;
        private string pwd;
        public User() { }
        public User(string user_name, string user_pwd)
        {
            name = user_name;
            pwd = user_pwd;
        }
        public string Login { get { return name; } }
        public string Password { get { return pwd; } }
    }
}

