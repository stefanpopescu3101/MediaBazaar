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

        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool CheckDetails(string username, string password)
        {
            if (username==this.username && password==this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
