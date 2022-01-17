using MediaBazaarWebsite.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaBazaarWebsiteUnitTests
{
    [TestClass]
    public class LoginUnitTests
    {
        [TestMethod]
        public void LoginConstrTest()
        {
            //arrange
            Login l = new Login("rr", "123rr");
            //act
            //assert
            Assert.AreEqual("123rr", l.Password);
        }

        [TestMethod]
        public void GetEmployeesMethodTest()
        {
            //arrange
            Employee emp = new Employee("Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager");
            MockLoginMediator mock = new MockLoginMediator();
            LoginManager m = new LoginManager(mock);
            //act
            m.AddEmployee(emp);

            //assert
            Assert.AreEqual(1, m.GetEmployees().Count);
        }


        [TestMethod]
        public void CheckingBeforeLoginMethodTest()
        {
            //arrange
            bool check = false;
            Employee emp = new Employee(1,"Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager",null,"123rr","123");
            MockLoginMediator mock = new MockLoginMediator();
            LoginManager m = new LoginManager(mock);
            //act
            m.AddEmployee(emp);
            if (m.checkIfExists("123rr", "123"))
            {
                check = true;
            }

            //assert
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void GetEmployeeMethodTest()
        {
            //arrange
            bool check = false;
            Employee emp = new Employee(1, "Rawan", "Alhabsi", 12345678, "rwn@gmail.com", "22/1/2022", null, "23/09/2001", "FullTime", 22, "tt", "HR", "HR Manager", null, "123rr", "123");
            MockLoginMediator mock = new MockLoginMediator();
            LoginManager m = new LoginManager(mock);
            //act
            m.AddEmployee(emp);
            if (m.GetEmployee("123rr", "123")!=null)
            {
                check = true;
            }

            //assert
            Assert.AreEqual(false, check);
        }
    }
}
