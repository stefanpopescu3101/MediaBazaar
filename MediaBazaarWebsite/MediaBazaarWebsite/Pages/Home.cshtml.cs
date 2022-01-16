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
<<<<<<< HEAD
    
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
            
=======
        [BindProperty]
        public bool Monday { get; set; }
        [BindProperty]
        public bool Tuesday { get; set; }
        [BindProperty]
        public bool Wednesday { get; set; }
        [BindProperty]
        public bool Thursday { get; set; }
        [BindProperty]
        public bool Friday { get; set; }
        [BindProperty]
        public bool Saturday { get; set; }
        [BindProperty]
        public bool Sunday { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public Employee Emp { get; set; }
        private LoginMediator med = new LoginMediator();
        public LoginManager manager;
        public ShiftManager ShiftManager = new ShiftManager();
        public List<WorkShift> workShifts = new List<WorkShift>();
        public List<Employee> employees = new List<Employee>();
        private EmployeeMediator med2 = new EmployeeMediator();
        public EmployeeManager empManager;
        public HomeModel()
        {
            manager = new LoginManager(med);
            empManager = new EmployeeManager(med2);
            manager.Load();
>>>>>>> hristo_prj
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
<<<<<<< HEAD
           
                }
             
=======
                    empManager.GetUnavailableDay(Emp);
                }
                if (this.Emp.UnAvailableDay=="Monday")
                {
                    Monday = true;
                }
                else if (this.Emp.UnAvailableDay == "Tuesday")
                {
                    Tuesday = true;
                }
                else if (this.Emp.UnAvailableDay == "Wednesday")
                {
                    Wednesday = true;
                }
                else if (this.Emp.UnAvailableDay == "Thursday")
                {
                    Thursday = true;
                }
                else if (this.Emp.UnAvailableDay == "Friday")
                {
                    Friday = true;
                }
                else if (this.Emp.UnAvailableDay == "Saturday")
                {
                    Saturday = true;

                }else if (this.Emp.UnAvailableDay == "Sunday")
                {
                    Sunday = true;
                }
>>>>>>> hristo_prj
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

<<<<<<< HEAD
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


=======
        public IActionResult OnPostUnavailable()
        {
            string id = HttpContext.Session.GetString("id");
            if (empManager.GetEmployeeById(Convert.ToInt32(id))!=null)
            {
                Employee emp = empManager.GetEmployeeById(Convert.ToInt32(id));
                if (Monday==true && Tuesday==false && Wednesday==false && Thursday==false && Friday==false && Saturday==false && Sunday==false)
                {
                    emp.UnAvailableDay = "Monday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == true && Wednesday == false && Thursday == false && Friday == false && Saturday == false && Sunday == false)
                {
                    emp.UnAvailableDay = "Tuesday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == false && Wednesday == true && Thursday == false && Friday == false && Saturday == false && Sunday == false)
                {
                    emp.UnAvailableDay = "Wednesday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == false && Wednesday == false && Thursday == true && Friday == false && Saturday == false && Sunday == false)
                {
                    emp.UnAvailableDay = "Thursday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == false && Wednesday == false && Thursday == false && Friday == true && Saturday == false && Sunday == false)
                {
                    emp.UnAvailableDay = "Friday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == false && Wednesday == false && Thursday == false && Friday == false && Saturday == true && Sunday == false)
                {
                    emp.UnAvailableDay = "Saturday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else if (Monday == false && Tuesday == false && Wednesday == false && Thursday == false && Friday == false && Saturday == false && Sunday == true)
                {
                    emp.UnAvailableDay = "Sunday";
                    empManager.UpdateUnavailablityOfWorkshifts(emp);
                }
                else
                {
                    ViewData["Message"] = "you cannot choose more than one day!";

                    return Page();
                }
            }
           
            return RedirectToPage("Home");
>>>>>>> hristo_prj
        }

    }
}
