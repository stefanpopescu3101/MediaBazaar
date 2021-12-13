using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MediaBazaarWebsite.models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class UpdateCredentialModel : PageModel
    {
        public Employee Employee { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Passwords don't match.")]
        public string NewPassword2 { get; set; }

        private LoginMediator loginMediator = new LoginMediator();
        public LoginManager loginManager;

        public UpdateCredentialModel()
        {
            loginManager = new LoginManager(loginMediator);
        }

        public void OnGet()
        {
            if (HttpContext.Session.Get("id") != null)
            {
                string id = HttpContext.Session.GetString("id");
                if (loginManager.GetEmployeeByID(Convert.ToInt32(id)) != null)
                {
                    this.Employee = loginManager.GetEmployeeByID(Convert.ToInt32(id));
                }
            }
            else RedirectToPage("Index");
        }

        public IActionResult OnPost()
        {
            string id = HttpContext.Session.GetString("id");
            this.Employee = loginManager.GetEmployeeByID(Convert.ToInt32(id));


            if (ModelState.IsValid)
            {
                if (CurrentPassword == this.Employee.Password)
                {
                    if (NewPassword == NewPassword2)
                    {
                        this.Employee = loginManager.UpdatePassword(Employee.ID, NewPassword);
                        ViewData["UpdateMessage"] = "Password has been successfully changed.";
                        return Page();
                    }
                    else
                    {
                        ViewData["UpdateMessage"] = "Passwords must be the same.";
                        return Page();
                    }
                }
                else 
                { 
                    ViewData["UpdateMessage"] = "Enter your current password correctly.";
                    return Page();
                }
            }
            else 
            {
                ViewData["UpdateMessage"] = "Fill in required fields.";
                return Page();
            }


        }
    }
}
