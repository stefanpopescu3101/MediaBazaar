using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
     public interface ILoginMdiator
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(string password, string username);
        public bool UpdatePassword(Employee employee);
    }
}
