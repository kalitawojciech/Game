using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class User
    {
        public string name { get; private set; }
        protected string password { get; private set; }
        int age { get; set; }
        string country { get; set; }
        private User(string name, string password) { this.name = name; this.password = password; }
    }
}
