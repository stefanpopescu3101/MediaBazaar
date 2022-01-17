using MediaBazaarWebsite.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebsiteUnitTests
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
    }
}
