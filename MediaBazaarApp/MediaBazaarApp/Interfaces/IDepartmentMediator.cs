using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Interfaces
{
    public interface IDepartmentMediator
    {
        public bool Add(Department department);
        public List<Department> GetAll();
        public bool Remove(Department department);
        public bool Update(string departmentName, Employee departmentManager);
    }
}
