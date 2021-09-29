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
        public User LoginCheck(string username, string password)
        { 
            foreach (User user in this.GetAll())
            {
                if (user.CheckDetails(username, password))
                {
                    return user;
                }
            }
            return null;
        }

        public User[] GetAll()
        {
            return users.ToArray();
        }

        //public Employee[] GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    foreach (User user in GetAll())
        //    {
        //        if (user is Employee)
        //        {
        //            Employee emp = (Employee)user;
        //            employees.Add(emp);

        //        }
        //    }
        //    return employees.ToArray();
        //}
    }
}
