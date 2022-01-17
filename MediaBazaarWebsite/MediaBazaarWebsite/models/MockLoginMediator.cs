using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class MockLoginMediator : ILoginMdiator
    {
        public Employee GetEmployee(string password, string username)
        {
            return null;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> emp = new List<Employee>();
            return emp;
        }
    }
}
