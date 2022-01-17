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
        [BindProperty]
        public DateTime UnavailableDate { get; set; }
        public UnavailableShift Unavailable { get; set; }
        private LoginMediator med = new LoginMediator();
        public LoginManager manager;

        public ShiftManager ShiftManager = new ShiftManager();

       public List<WorkShift> workShifts = new List<WorkShift>();
        public List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();

        //public List<WorkShift> workShifts = new List<WorkShift>();
        //public List<Employee> employees = new List<Employee>();
        //private EmployeeMediator med2 = new EmployeeMediator();
        //public EmployeeManager empManager;

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

        public IActionResult OnPostReset()
        {
            string id = HttpContext.Session.GetString("id");
            this.workShifts = ShiftManager.GetWorkShiftsOfCurrentMonth(Convert.ToInt32(id), DateTime.Now.Month, DateTime.Now.Year);
            this.Emp = manager.GetEmployeeByID(Convert.ToInt32(id));
            Name = Emp.FirstName + " " + Emp.LastName;
            return Page();
        }

        public IActionResult OnPostPrevious()
        {
            string id = HttpContext.Session.GetString("id");
            this.workShifts = ShiftManager.PreviousMonth(Convert.ToInt32(id), DateTime.Now.Month, DateTime.Now.Year);
            this.Emp = manager.GetEmployeeByID(Convert.ToInt32(id));
            Name = Emp.FirstName + " " + Emp.LastName;
            return Page();
        }
        public IActionResult OnPostNext()
        {
            string id = HttpContext.Session.GetString("id");
            this.workShifts = ShiftManager.NextMonth(Convert.ToInt32(id), DateTime.Now.Month, DateTime.Now.Year);
            this.Emp = manager.GetEmployeeByID(Convert.ToInt32(id));
            Name = Emp.FirstName + " " + Emp.LastName;
            return Page();
        }

        public IActionResult OnPostShow()
        {
            string id = HttpContext.Session.GetString("id");
            this.unavailableShifts = ShiftManager.GetUnavailableShiftsEmployee(Convert.ToInt32(id));
            return Page();
        }


        public IActionResult OnPostConfirm()
        {
            string id = HttpContext.Session.GetString("id");
            var date = DateTime.Parse(UnavailableDate.ToString()).ToShortDateString();
            this.Unavailable = new UnavailableShift(Convert.ToInt32(id), date);
            this.ShiftManager.AddUnavailableShift(Unavailable);
            return Page();



        }

    }
}
