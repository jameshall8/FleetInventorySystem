using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetInventorySystem
{
    class User
    {
        String username;
        String password;
        String role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        int viewTime()
        {
            return 5;
        }
    }
}
