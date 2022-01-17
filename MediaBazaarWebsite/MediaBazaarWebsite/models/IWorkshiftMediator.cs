using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public interface IWorkshiftMediator
    {
         List<WorkShift> GetAll();
        List<UnavailableShift> GetAllUnavailable();
        bool AddUnavailableShift(UnavailableShift unavailableShift);
       
    }
}
