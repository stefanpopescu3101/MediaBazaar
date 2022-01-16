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
<<<<<<< HEAD

        public List<UnavailableShift> UnavailableShifts { get; private set; }
=======
>>>>>>> hristo_prj
        private ShiftMediator shiftMediator;

        public ShiftManager()
        {
            this.WorkShifts = new List<WorkShift>();
<<<<<<< HEAD
            this.UnavailableShifts = new List<UnavailableShift>();
            this.shiftMediator = new ShiftMediator();
            this.Load();
            this.LoadUnavailable();
=======
            this.shiftMediator = new ShiftMediator();
            this.Load();
>>>>>>> hristo_prj
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
<<<<<<< HEAD

        public List<UnavailableShift> GetUnavailableShifts()
        {
            List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
            foreach(UnavailableShift unavailableShift in this.UnavailableShifts)
            {
                unavailableShifts.Add(unavailableShift);
            }

            return unavailableShifts;
        }
=======
>>>>>>> hristo_prj
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


<<<<<<< HEAD
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


=======
>>>>>>> hristo_prj

        public bool Load()
        {
            this.WorkShifts = this.shiftMediator.GetAll();
            if (this.WorkShifts != null)
            {
                return true;
            }
            else { return false; }
        }

<<<<<<< HEAD
        public bool LoadUnavailable()
        {
            this.UnavailableShifts = this.shiftMediator.GetAllUnavailable();
            if(this.UnavailableShifts != null)
            {
                return true;
            }

            return false;
        }

=======
>>>>>>> hristo_prj
      
    }
}
