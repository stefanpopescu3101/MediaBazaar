using MediaBazaarWebsite.models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Login login { get; set; }

        private LoginMediator med = new LoginMediator();
        public LoginManager manager;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            manager = new LoginManager(med);
            manager.Load();
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(string? returnUrl)
        {
            if (ModelState.IsValid)

            {

                if (manager.checkIfExists(login.Password, login.Username) == true)
                {
                    Employee employee = manager.GetEmployee(login.Password, login.Username);
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, employee.FirstName));
                    claims.Add(new Claim("id", employee.ID.ToString()));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    HttpContext.Session.SetString("id", employee.ID.ToString());
                    // Url.IsLocalUrl is to prevent Open Redirect Attacks
                    // See 'What is an Open Redirection Attack?' @ https://docs.microsoft.com/en-us/aspnet/mvc/overview/security/preventing-open-redirection-attacks)
                    if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToPage("Home");
                    }

                }
                else
                {
                    ViewData["Message"] = "This username and password do not exist";

                    return Page();
                }

            }

            else

            {

                ViewData["Message"] = "Please enter all data fields!";

                return Page();

            }
        }
    }
}
