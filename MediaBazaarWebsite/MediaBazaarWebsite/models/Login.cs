using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class Login
    {
        public Login()
        {

        }
        public Login(string username, string password)
        {

            this.Username = username;
            this.Password = password;
        }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
