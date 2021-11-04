using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Scheduler
    {
        public List<WorkShift> AllShifts { get { return this.shiftManager.GetActiveShifts(); } }

        private ShiftManager shiftManager;
        private EmployeeManager employeeManager;
        private EmployeesMediator employeeMediator;

        public EmployeeManager EmployeeManager { get { return employeeManager; } }
        public Scheduler()
        {
            this.shiftManager = new ShiftManager();
            this.employeeManager = new EmployeeManager();
            this.employeeMediator = new EmployeesMediator();
        }

        public int CheckNumberOfAssignedEmployees(string date, string type)
        {
            int assignedEmployees = 0;
            foreach (WorkShift shift in this.AllShifts)
            {
                if (shift.Date == date && shift.Type == type)
                {
                    assignedEmployees++;
                }
            }
            return assignedEmployees;
        }

        public List<Employee> GetAssignedEmployeesToShift(string date, string type)
        {
            List<Employee> employees = new List<Employee>();
            foreach (WorkShift ws in AllShifts)
            {
                foreach (Employee emp in employeeManager.GetEmployees())
                {
                    if (ws.Date == date && ws.Type == type && ws.EmployeeId == emp.ID)
                    {
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
        public List<Employee> GetAvailableEmployees(string date, string shiftType)
        {
            List<Employee> employees = new List<Employee>();
            foreach (WorkShift ws in AllShifts)
            {
                foreach (Employee emp in employeeManager.GetEmployees())
                {
                    if (ws.Date != date && ws.Type != shiftType && ws.EmployeeId == emp.ID)
                    {
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }

        private bool MaximumShifts(Employee employee, string monday1, string sunday1)
        {
            DateTime monday = DateTime.ParseExact(monday1, "M/d/yyyy", null);
            DateTime sunday = DateTime.ParseExact(sunday1, "M/d/yyyy", null);
            int numberOfShifts = 0;

            foreach (WorkShift shift in this.AllShifts)
            {
                if (shift.EmployeeId == employee.ID)
                {
                    if (DateTime.Compare(monday, DateTime.ParseExact(shift.Date, "M/d/yyyy", null)) <= 0 &&
                    DateTime.Compare(sunday, DateTime.ParseExact(shift.Date, "M/d/yyyy", null)) >= 0)
                    {
                        numberOfShifts++;
                    }
                }
            }
            if (employee.ContractType == "FullTime")
            {
                if (numberOfShifts >= 5) { return true; }
            }
            else if (employee.ContractType == "PartTime")
            {
                if (numberOfShifts >= 4) { return true; }
            }
            return false;
        }
        private bool CheckEmployeesShiftsForToday(int employeeID, string date)
        {
            List<WorkShift> shiftsToday = this.shiftManager.GetShiftsForSpecificDate(date);
            if (shiftsToday.Count > 0)
            {
                foreach (WorkShift shift in shiftsToday)
                {
                    if (shift.EmployeeId == employeeID)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public List<Employee> GetAvailableEmployees( string date, string monday, string sunday)
        {
            List<Employee> employees = this.employeeManager.GetEmployees();
            List<Employee> availableEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (!this.MaximumShifts(employee, monday, sunday))
                {
                 
                        if (this.CheckEmployeesShiftsForToday(employee.ID, date))
                        {
                            availableEmployees.Add(employee);
                        }
                    
                }
            }
            return availableEmployees;
        }

        }
}
