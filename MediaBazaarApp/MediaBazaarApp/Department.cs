using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Department
    {
        private string departmentName;
        private int managerID;
        private string managerName;

        List<Employee> employees;
        public string DepartmentName { get { return departmentName; } }
        public int ManagerID { get { return managerID; } }
        public string ManagerName { get { return managerName; } }
     

        public Department(string departmentName, Employee departmentManager)
        {
            employees = new List<Employee>();
            this.managerID = departmentManager.ID;
            this.departmentName = departmentName;
            this.managerName = departmentManager.Name;
        }
        public Department(string departmentName, int Managerid)
        {
            this.departmentName = departmentName;
            UserManager user = new UserManager();
           if(user.GetEmployee(managerID) != null)
            {
                this.managerName = user.GetEmployee(managerID).Name;
                this.managerID = Managerid;
            }
         
        }
        public void EditInfo(string departmentName, Employee departmentManager)
        {
            this.departmentName = departmentName;
            this.managerID = departmentManager.ID;
            this.managerName = departmentManager.Name;
        }
        public bool AssignEmployee(Employee emp)
        {
            if (!employees.Contains(emp))
            {
                employees.Add(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveEmployee(Employee emp)
        {
            if (employees.Contains(emp))
            {
                employees.Remove(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee[] GetEmployees()
        {
            return employees.ToArray();
        }
        public override string ToString()
        {
            return $"Name: {this.departmentName}and manager: {this.managerName}({this.managerID})";
        }
    }
}
