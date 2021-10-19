using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class EmployeeManager
    {
        private static int id = 0;
        List<Employee> employees;
        EmployeesMediator employeesMediator;

        public EmployeeManager()
        {
            employees = new List<Employee>();
            employeesMediator = new EmployeesMediator();
        }
        public void GenerateUsernameAndPassword(Employee emp)
        {
            string userName = emp.FirstName.Substring(0, 1) + emp.LastName.Substring(0, 1) + emp.ID;
            emp.UserName = userName;
            emp.Password = emp.ID + id++.ToString();
            employeesMediator.UpdateUsernameAndPassword(emp);

        }
        public Employee CheckCredentials(string username,string password)
        {
            foreach (Employee emp in employees)
            {
                if (emp.UserName==username && emp.Password==password)
                {
                    return emp;
                }
            }
            return null;
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
        public void Load()
        {
            employees = employeesMediator.GetEmployees();
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
    }
}
