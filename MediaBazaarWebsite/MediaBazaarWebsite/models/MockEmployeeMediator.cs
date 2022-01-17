using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class MockEmployeeMediator : IEmployeeMediator
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> emp = new List<Employee>();
            return emp;
        }

        public bool GetUnavailableDay(Employee employee)
        {
            return true;
        }

        public bool UpdateUavailblityOfWorkshifts(Employee employee)
        {
            return true;
        }
    }
}
