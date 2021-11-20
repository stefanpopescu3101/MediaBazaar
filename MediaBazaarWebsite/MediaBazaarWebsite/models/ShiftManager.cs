using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
   public class ShiftManager
    {
        public List<WorkShift> WorkShifts { get; private set; }
        private ShiftMediator shiftMediator;

        public ShiftManager()
        {
            this.WorkShifts = new List<WorkShift>();
            this.shiftMediator = new ShiftMediator();
            this.Load();
        }

      

        public List<WorkShift> GetActiveShifts()
        {
            List<WorkShift> activeShifts = new List<WorkShift>();
            foreach (WorkShift workShift in this.WorkShifts)
            {
                if (!workShift.Cancelled)
                {
                    activeShifts.Add(workShift);
                }
            }
            return activeShifts;
        }
        public List<WorkShift> GetWorkShiftsOfCurrentMonth(int id ,int month, int year)
        {
            string date = new DateTime(year, month, 1).ToString("d");
            string lastdate = DateTime.DaysInMonth(year, month).ToString();
            string lastDate = new DateTime(year, month,Convert.ToInt32( lastdate)).ToString("d");
            List<WorkShift> workShiftsOfCurrentMonth = new List<WorkShift>();
            foreach (WorkShift shift in GetActiveShifts())
            {
                if (shift.EmployeeId==id)
                {
                    if (DateTime.ParseExact(shift.Date, "M/d/yyyy",null) >= DateTime.ParseExact(date, "M/d/yyyy", null) && DateTime.ParseExact(shift.Date, "M/d/yyyy", null) <= DateTime.ParseExact(lastDate, "M/d/yyyy", null))
                    {
                        workShiftsOfCurrentMonth.Add(shift);
                    }
                }
            }
            return workShiftsOfCurrentMonth;
        }

        public List<WorkShift> PreviousMonth(int id, int month, int year)
        {
            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }
            string date = new DateTime(year, month, 1).ToString("d");
            string lastdate = DateTime.DaysInMonth(year, month).ToString();
            string lastDate = new DateTime(year, month, Convert.ToInt32(lastdate)).ToString("d");
            List<WorkShift> workShiftsOfCurrentMonth = new List<WorkShift>();
            foreach (WorkShift shift in GetActiveShifts())
            {
                if (shift.EmployeeId == id)
                {
                    if (DateTime.ParseExact(shift.Date, "M/d/yyyy", null) >= DateTime.ParseExact(date, "M/d/yyyy", null) && DateTime.ParseExact(shift.Date, "M/d/yyyy", null) <= DateTime.ParseExact(lastDate, "M/d/yyyy", null))
                    {
                        workShiftsOfCurrentMonth.Add(shift);
                    }
                }
            }
            return workShiftsOfCurrentMonth;
        }

        public List<WorkShift> NextMonth(int id, int month, int year)
        {
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
            string date = new DateTime(year, month, 1).ToString("d");
            string lastdate = DateTime.DaysInMonth(year, month).ToString();
            string lastDate = new DateTime(year, month, Convert.ToInt32(lastdate)).ToString("d");
            List<WorkShift> workShiftsOfCurrentMonth = new List<WorkShift>();
            foreach (WorkShift shift in GetActiveShifts())
            {
                if (shift.EmployeeId == id)
                {
                    if (DateTime.ParseExact(shift.Date, "M/d/yyyy", null) >= DateTime.ParseExact(date, "M/d/yyyy", null) && DateTime.ParseExact(shift.Date, "M/d/yyyy", null) <= DateTime.ParseExact(lastDate, "M/d/yyyy", null))
                    {
                        workShiftsOfCurrentMonth.Add(shift);
                    }
                }
            }
            return workShiftsOfCurrentMonth;
        }



        public bool Load()
        {
            this.WorkShifts = this.shiftMediator.GetAll();
            if (this.WorkShifts != null)
            {
                return true;
            }
            else { return false; }
        }

      
    }
}
