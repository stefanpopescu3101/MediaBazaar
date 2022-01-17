using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class MockWorkshiftMediator : IWorkshiftMediator
    {
        public bool AddUnavailableShift(UnavailableShift unavailableShift)
        {
            return true;
        }

        public List<WorkShift> GetAll()
        {
            List<WorkShift> workShifts = new List<WorkShift>();
            return workShifts;
        }

        public List<UnavailableShift> GetAllUnavailable()
        {
            List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
            return unavailableShifts;
        }
    }
}
