using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class EmployeeManager
    {
       private List<Employee> employees;
        IEmployeeMediator med;

        public EmployeeManager(IEmployeeMediator med)
        {
            employees = new List<Employee>();
            this.med = med;
            Load();
        }

        public void Load()
        {
            this.employees = med.GetEmployees();
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void UpdateUnavailablityOfWorkshifts(Employee emp)
        {
            med.UpdateUavailblityOfWorkshifts(emp);
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.ID==id)
                {
                    return emp;
                }
            }
            return null;
        }
        public void GetUnavailableDay(Employee e)
        {
            med.GetUnavailableDay(e);
        }
    }
}
