using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormPageApp.Services
{
    public class AuthenticationService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "Maya", "password1" },
        { "Ammu", "password2" },
        { "Minu", "password3" }
    };

        public bool Authenticate(string username, string password)
        {
            if (users.ContainsKey(username) && users[username] == password)
            {
                return true;
            }
            return false;
        }
    }
}
