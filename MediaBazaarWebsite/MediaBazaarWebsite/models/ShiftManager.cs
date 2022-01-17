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

        public List<UnavailableShift> UnavailableShifts { get; private set; }

        private IWorkshiftMediator shiftMediator;

        public ShiftManager(IWorkshiftMediator shiftMediator)
        {
            this.WorkShifts = new List<WorkShift>();
            this.UnavailableShifts = new List<UnavailableShift>();
            this.shiftMediator = shiftMediator;
            this.Load();
            this.LoadUnavailable();
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

        public List<UnavailableShift> GetUnavailableShifts()
        {
            List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
            foreach(UnavailableShift unavailableShift in this.UnavailableShifts)
            {
                unavailableShifts.Add(unavailableShift);
            }

            return unavailableShifts;
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
        public void AddWorkshift(WorkShift w)
        {
            WorkShifts.Add(w);
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

        public List<UnavailableShift> GetUnavailableShiftsEmployee(int id)
        {
            
            List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
            foreach (UnavailableShift shift in GetUnavailableShifts())
            {
                if (shift.EmployeeId == id)
                {
                    unavailableShifts.Add(shift);
                }
            }
            return unavailableShifts;
        }

        public bool AddUnavailableShift(UnavailableShift shift)
        {
            if(shift!=null)
            {
                this.UnavailableShifts.Add(shift);
                this.shiftMediator.AddUnavailableShift(shift);
                return true;
            }

            return false;
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

        public bool LoadUnavailable()
        {
            this.UnavailableShifts = this.shiftMediator.GetAllUnavailable();
            if(this.UnavailableShifts != null)
            {
                return true;
            }

            return false;
        }
      
    }
}
