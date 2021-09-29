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
        DepartmentMediator mediator;

        public DepartmentManager()
        {
            departments = new List<Department>();
            mediator = new DepartmentMediator();
        }

        public bool Add(Department department)
        {
            foreach (Department d in GetDepartments())
            {
                if (d.DepartmentName!=department.DepartmentName)
                {
                    departments.Add(department);
                    mediator.Add(department);
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
                    mediator.Remove(d);
                    departments.Remove(d);
                    return true;
                }
            }
            return false;
        }
        public Department[] GetDepartments()
        {
            return mediator.GetAll().ToArray();
        }
        public Department GetDepartment(string name)
        {
            foreach (Department d in GetDepartments())
            {
                if (d.DepartmentName==name)
                {
                    return d;
                }
            }
            return null;
        }

    }
}
