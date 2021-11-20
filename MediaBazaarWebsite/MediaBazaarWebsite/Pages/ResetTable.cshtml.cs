using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarWebsite.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class ResetTableModel : PageModel
    {
        public ShiftManager ShiftManager = new ShiftManager();
        public List<WorkShift> workShifts = new List<WorkShift>();
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string id = HttpContext.Session.GetString("id");
            this.workShifts = ShiftManager.GetWorkShiftsOfCurrentMonth(Convert.ToInt32(id), DateTime.Now.Month, DateTime.Now.Year);
            return RedirectToPage("Home");
        }
    }
}
