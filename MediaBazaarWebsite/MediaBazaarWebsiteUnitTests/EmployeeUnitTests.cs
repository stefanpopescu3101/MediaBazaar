using MediaBazaarWebsite.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaBazaarWebsiteUnitTests
{
    [TestClass]
    public class EmployeeUnitTests
    {
        [TestMethod]
        public void EmployeeConstrTest()
        {
            //arrange
            Employee emp = new Employee("Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager");
            //act
            //assert
            Assert.AreEqual("Rawan", emp.FirstName);
        }
        [TestMethod]
        public void GetEmployeesMethodTest()
        {
            //arrange
            Employee emp = new Employee("Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager");
            MockEmployeeMediator mock = new MockEmployeeMediator();
            EmployeeManager m = new EmployeeManager(mock);
            //act
            m.AddEmployee(emp);

            //assert
            Assert.AreEqual(1, m.GetEmployees().Count);
        }

        [TestMethod]
        public void GetEmployeeByIDMethodTest()
        {
            //arrange
            Employee emp = new Employee(1,"Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager",null,null,null);
            MockEmployeeMediator mock = new MockEmployeeMediator();
            EmployeeManager m = new EmployeeManager(mock);
            //act
            m.AddEmployee(emp);

            //assert
            Assert.AreEqual(emp.FirstName, m.GetEmployeeById(1).FirstName);
        }
    }
}
