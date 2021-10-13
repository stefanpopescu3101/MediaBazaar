using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class UserManager
    {
        List<User> users;
        public UserManager()
        {
            users = new List<User>();
        }
   

        public User[] GetAll()
        {
            return users.ToArray();
        }

        public Employee[] GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (User user in GetAll())
            {
                if (user is Employee)
                {
                    Employee emp = (Employee)user;
                    employees.Add(emp);

                }
            }
            return employees.ToArray();
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in GetEmployees())
            {
                if (emp.ID == id)
                {
                    return emp;
                }
            }
            return null;

        }
    }
}
