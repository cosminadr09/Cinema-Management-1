using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneFilmBilete1.model
{
    class User
    {
        public String name {  get; private set; } //everyone can read the property but only the class can modify it
        public String username { get; private set; }
        public String password { get; private set; }

        public User(String name, String username, String pass)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        
    }
}
