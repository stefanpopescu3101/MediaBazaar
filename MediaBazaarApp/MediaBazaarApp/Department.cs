using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Department
    {
        private string departmentName;
        private Employee departmentManager;

        List<Employee> employees;

        public Department(string departmentName, Employee departmentManager)
        {
            employees = new List<Employee>();
            this.departmentManager = departmentManager;
            this.departmentName = departmentName;

        }

    }
}
