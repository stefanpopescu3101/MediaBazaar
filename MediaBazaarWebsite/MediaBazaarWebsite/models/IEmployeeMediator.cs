using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
   public interface IEmployeeMediator
    {
        List<Employee> GetEmployees();
        bool UpdateUavailblityOfWorkshifts(Employee employee);
    }
}
