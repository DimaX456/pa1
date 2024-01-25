using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1
{
    public class checkUser
    {
        public string LoginUser { get; set; }

        public bool LoginPassword { get; }

        //public string Status => IsAdmin ? "Admin" : "User";

        public checkUser(string LoginUser, bool LoginPassword)
        {
            LoginUser = LoginUser.Trim();
            //IsAdmin = IsAdmin;
        }
    }
}
