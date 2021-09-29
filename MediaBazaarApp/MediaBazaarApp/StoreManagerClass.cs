using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class StoreManagerClass:Employee
    {
        public StoreManagerClass(string firstName, string lastName, int BSN, string email,
            string firstWorkingDate, string lastWorkingDate, string birthdate,
            string contractType, double hourlyWage, string address,
            string department) : base(firstName, lastName, BSN, email, firstWorkingDate, lastWorkingDate, birthdate, contractType, hourlyWage, address, department)
        {
        }
    }
}
