using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
   public abstract class User
    {
        protected string username;
        protected string password;


        public User()
        {
            //this.username = username;
            //this.password = password;

        }
        public string UserName { get { return username; }set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    



    }
}
