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
            employees.Add(employee);
            employeesMediator.AddEmployee(employee);
        }

        public void RemoveEmployee(Employee emp)
        {
            employeesMediator.RemoveEmployee(emp);
            employees.Remove(emp);
        }

        //public Employee GetEmployee(int id)
        //{
        //    foreach (Employee emp in employees)
        //    {
        //        if (emp.ID==id)
        //        {
        //            return emp;


        public Employee GetEmployee(int id)
        {
            foreach(Employee e in GetEmployees())
            {
                if(e.ID == id)
                {
                    return e;
                }
            }
            return null;
        }

        public List<Employee> GetEmployees()
        {
            employees = employeesMediator.GetEmployees();
            return employees;
        }
        public List<Employee> GetEmployeeOfDepartment(Department depart)
        {
            return employeesMediator.GetEmployeesOfDepartment(depart);
        }

        public void UpdateRoleAndDepartment(Employee emp, string department, string Role)
        {
            employeesMediator.UpdateRoleAndDepartment(emp, department, Role);
        }

        public void Update(Employee employee, string firstName, string lastName, string email,
            string contractType, string address,
            string department)
        {
            employee.UpdateInfo(firstName, lastName, email, contractType, address, department);
            employeesMediator.Update(employee);
        }

        public void TerminateEmployeesContract(Employee employee, string endDate, string reason)
        {
            employeesMediator.TerminateContract(employee, endDate, reason);
            employee.TerminateContract(reason, endDate);
        }
    }
}
