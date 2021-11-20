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
    public class HomeModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public Employee Emp { get; set; }
        private LoginMediator med = new LoginMediator();
        public LoginManager manager;
        public HomeModel()
        {
            manager = new LoginManager(med);
            manager.Load();
        }
        public void OnGet()
        {
            if (HttpContext.Session.Get("id") != null)
            {
                string id = HttpContext.Session.GetString("id");
                if (manager.GetEmployeeByID(Convert.ToInt32(id)) != null)
                {
                    this.Emp = manager.GetEmployeeByID(Convert.ToInt32(id));
                    Name = Emp.FirstName + " " + Emp.LastName;
                }
              
            }
        }
    }
}
