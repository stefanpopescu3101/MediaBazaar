using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class LoginManager
    {
        private List<Employee> employees;
        private ILoginMdiator mediator;
        public LoginManager(ILoginMdiator mediator)
        {
            this.mediator = mediator;
            employees = new List<Employee>();
            Load();
        }

        public void Load()
        {
            this.employees = mediator.GetEmployees();
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public bool checkIfExists(string password, string username)
        {
            foreach (Employee emp in GetEmployees())
            {
                if (emp.Password==password && emp.UserName==username)
                {
                    return true;
                }
              
            }
            return false;
        }

        public Employee GetEmployee(string password, string username)
        {
            foreach (Employee emp in GetEmployees())
            {
                if (emp.Password == password && emp.UserName == username)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee GetEmployeeByID(int id)
        {
            foreach (Employee emp in GetEmployees())
            {
                if (emp.ID==id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee UpdatePassword(int id, string newPassword)
        {
            Employee employee = GetEmployeeByID(id);
            employee.UpdatePassword(newPassword);
            mediator.UpdatePassword(employee);
            return employee;
        }
    }
}
