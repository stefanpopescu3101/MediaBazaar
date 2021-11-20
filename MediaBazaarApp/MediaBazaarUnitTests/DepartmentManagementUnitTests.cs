using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaBazaarApp;
using MediaBazaarApp.Classes.DataAccess;
namespace MediaBazaarUnitTests
{
    [TestClass]
    public class DepartmentManagementUnitTests
    {
        [TestMethod]
        public void AddDepartmentTest()
        {
            //arrange   
            bool check = false;
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            MockDepartmentMediator med = new MockDepartmentMediator();
            DepartmentManager manager = new DepartmentManager(med);
            //act
            check=manager.Add(department);
            //assert
            Assert.AreEqual(check, true);

        }

        [TestMethod]
        public void GetDepartmentsTest()
        {
            //arrange   
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            MockDepartmentMediator med = new MockDepartmentMediator();
            DepartmentManager manager = new DepartmentManager(med);
            //act
            manager.Add(department);
            //assert
            Assert.AreEqual(manager.GetDepartments().Length, 1);

        }

        [TestMethod]
        public void RemoveDepartmentTest()
        {
            //arrange   
            int success = 0;
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            MockDepartmentMediator med = new MockDepartmentMediator();
            DepartmentManager manager = new DepartmentManager(med);
            //act
            manager.Add(department);
            if(manager.Remove(department))
            {
                success++;
            }
            //assert
            Assert.AreEqual(success, 1);

        }

        [TestMethod]
        public void UpdateDepartmentTest()
        {
            //arrange   
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            MockDepartmentMediator med = new MockDepartmentMediator();
            DepartmentManager manager = new DepartmentManager(med);
            //act
            manager.Update(department, "logistics", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            //assert
            Assert.AreEqual(department.DepartmentName, "logistics");

        }

        [TestMethod]
        public void GetDepartmentTest()
        {
            //arrange   
            int success = 0;
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            MockDepartmentMediator med = new MockDepartmentMediator();
            DepartmentManager manager = new DepartmentManager(med);
            //act
            manager.Add(department);
            if (manager.GetDepartment("HR")!=null)
            {
                success++;
            }
            //assert
            Assert.AreEqual(success, 1);

        }

        [TestMethod]
        public void AssignEmployeeToDepartmentTest()
        {
            //arrange   
            int success = 0;
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            Employee emp = new Employee("marwan", "alhabsi", 123456789, "marwan@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager");
            //act
           if(department.AssignEmployee(emp))
            {
                success++;
            }
           
            //assert
            Assert.AreEqual(success, 1);

        }

        [TestMethod]
        public void RemoveEmployeeFromDepartmentTest()
        {
            //arrange   
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            Employee emp = new Employee("marwan", "alhabsi", 123456789, "marwan@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager");
            //act
            department.AssignEmployee(emp);
            department.RemoveEmployee(emp);

            //assert
            Assert.AreEqual(department.GetEmployees().Length, 0);

        }

        [TestMethod]
        public void GetEmployeesOfDepartmentTest()
        {
            //arrange   
            Department department = new Department("HR", new Employee("rwn", "alhabsi", 123456789, "rwn@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager"));
            Employee emp = new Employee("marwan", "alhabsi", 123456789, "marwan@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager");
            Employee emp2 = new Employee("marwan2", "alhabsi2", 123456789, "marwan2@gmail.com", "11/20/2021", null, "23/09/2001", "Fulltime", 20, "rwn", "HR", "HRManager");
            //act
            department.AssignEmployee(emp);
            department.AssignEmployee(emp2);

            //assert
            Assert.AreEqual(department.GetEmployees().Length, 2);

        }


    }
}
