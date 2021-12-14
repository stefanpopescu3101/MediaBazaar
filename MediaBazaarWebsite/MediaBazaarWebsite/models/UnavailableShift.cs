using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class UnavailableShift
    {

        public int EmployeeId { get; private set; }

        public string UnavailableDay { get;  set; }

        public UnavailableShift(int employeeID, string unavailableTime)
        {
            this.EmployeeId = employeeID;
            this.UnavailableDay = unavailableTime;
        }

        public override string ToString()
        {
            return $"ID : {EmployeeId}, Day : {UnavailableDay}";
        }
    }
}
