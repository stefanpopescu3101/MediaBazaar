using MediaBazaarApp.Interfaces;
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

        IDepartmentMediator mediator;


        public DepartmentManager(IDepartmentMediator mediator)
        {
            departments = new List<Department>();

           this. mediator = mediator;

        }

        public bool Add(Department department)
        {

            if (GetDepartments().Length != 0)
            {
                foreach (Department d in GetDepartments())
                {
                    if (d.DepartmentName != department.DepartmentName)
                    {
                        departments.Add(department);
                        mediator.Add(department);
                        return true;
                    }
                }
             
            }
            else
            {
                departments.Add(department);
                mediator.Add(department);
                return true;

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
            return departments.ToArray();
        }

        public void Load()
        {
            departments = mediator.GetAll();
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
        public void Update(Department d,string departmentName, Employee departmentManager)
        {
            d.EditInfo( departmentName, departmentManager);
            mediator.Update(departmentName, departmentManager);
        }

    }
}
