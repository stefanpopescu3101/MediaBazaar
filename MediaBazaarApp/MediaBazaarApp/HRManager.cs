using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class HRManager:Employee
    {
        public HRManager(string username, string password, string firstName, string lastName, int BSN, string email,
            string gender, string firstWorkingDate, string lastWorkingDate, string birthdate,
            string contractType, double hourlyWage, string streetName, int streetNumber, string zipCode, string town, string country,
            string department, string role) : base(username, password, firstName, lastName, BSN, email, gender, firstWorkingDate, lastWorkingDate, birthdate, contractType, hourlyWage, streetName, streetNumber, zipCode, town, country, department, role)
        {
        }
    }
}
