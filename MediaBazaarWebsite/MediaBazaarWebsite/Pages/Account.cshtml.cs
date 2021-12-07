using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarWebsite.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class AccountModel : PageModel
    {
        [BindProperty]
        public Employee Emp { get; set; }
        private LoginMediator med = new LoginMediator();
        public LoginManager manager;

        public AccountModel()
        {
            manager = new LoginManager(med);
        }
        public void OnGet()
        {
            if (HttpContext.Session.Get("id") != null)
            {
                string id = HttpContext.Session.GetString("id");
                if (manager.GetEmployeeByID(Convert.ToInt32(id)) != null)
                {
                    this.Emp = manager.GetEmployeeByID(Convert.ToInt32(id));
                }
            }
        }
    }
}
