using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPN
{
    internal class User
    {
        public string Name { get; set; } = "USER";
        
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Id { get; private set; }

        public User(string login, string password, string id)
        {
            Login = login;
            Password = password;
            Id = id;
        }
    }
}
