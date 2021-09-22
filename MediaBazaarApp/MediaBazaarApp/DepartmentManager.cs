using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class DepartmentManager
    {
        List<Department> departments;

        public DepartmentManager()
        {
            departments = new List<Department>();
        }

        public bool Add(Department department)
        {
            foreach (Department d in departments)
            {
                if (d.DepartmentName!=department.DepartmentName)
                {
                    departments.Add(department);
                    return true;
                }
            }
            return false;
        }
        public bool Remove(Department department)
        {
            foreach (Department d in departments)
            {
                if (d.DepartmentName == department.DepartmentName)
                {
                    departments.Remove(department);
                    return true;
                }
            }
            return false;
        }
        public Department[] GetDepartments()
        {
            return departments.ToArray();
        }

    }
}
