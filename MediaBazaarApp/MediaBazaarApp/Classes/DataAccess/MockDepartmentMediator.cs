using MediaBazaarApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Classes.DataAccess
{
    public class MockDepartmentMediator : IDepartmentMediator
    {
        public bool Add(Department department)
        {
            return true;
        }

        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            return departments;
        }

        public bool Remove(Department department)
        {
            return true;
        }

        public bool Update(string departmentName, Employee departmentManager)
        {
            return true;
        }
    }
}
