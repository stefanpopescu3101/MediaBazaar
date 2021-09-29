using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class EmployeeManager
    {
        List<Employee> employees;
        EmployeesMediator employeesMediator;

        public EmployeeManager()
        {
            employees = new List<Employee>();
            employeesMediator = new EmployeesMediator();
        }

        public void AddEmployee(Employee employee)
        {
                //if(employee.ID != e.ID)
                //{
                //    employees.Add(employee);
                //    employeesMediator.AddEmployee(employee);
                //}
            employees.Add(employee);
            employeesMediator.AddEmployee(employee);
        }

        public void RemoveEmployee(int id)
        {
            employeesMediator.RemoveEmployee(id);
        }
        public Employee GetEmployee(int id)
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
        public List<Employee> GetEmployees()
        {
            return employeesMediator.GetEmployees();
        }
    }
}
