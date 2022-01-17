using MediaBazaarWebsite.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarWebsiteUnitTests
{
    [TestClass]
    public class WorkshiftUnitTests
    {
        [TestMethod]
        public void WorkshiftConstrTest()
        {
            //arrange
            WorkShift workShift = new WorkShift(1, "rawan", "22/1/2022", "AFTERNOON", 22, 2);
            //act
            //assert
            Assert.AreEqual(1, workShift.EmployeeId);
        }

        [TestMethod]
        public void CancelWorkshiftMethodTest()
        {
            //arrange
            WorkShift workShift = new WorkShift(1, "rawan", "22/1/2022", "AFTERNOON", 22, 2);
            //act
            workShift.CancelShift();
            //assert
            Assert.AreEqual(true, workShift.Cancelled);
        }

        //[TestMethod]
        //public void NextMonthMethodTest()
        //{
        //    //arrange
        //    int num = 0;
        //    WorkShift workShift = new WorkShift(1, "rawan", "22/1/2022", "AFTERNOON", 22, 2);
        //    WorkShift workShift1 = new WorkShift(1, "rawan", "22/2/2022", "AFTERNOON", 22, 2);
        //    MockWorkshiftMediator mock = new MockWorkshiftMediator();
        //    ShiftManager shift = new ShiftManager(mock);
        //    //act
        //    shift.AddWorkshift(workShift);
        //    shift.AddWorkshift(workShift1);
        //   num= shift.NextMonth(1, DateTime.Now.Month, DateTime.Now.Year).Count;
        //    //assert
        //    Assert.AreEqual(1, num);
        //}

        //[TestMethod]
        //public void PreviousMonthMethodTest()
        //{
        //    //arrange
        //    int num = 0;
        //    WorkShift workShift = new WorkShift(1, "rawan", "22/1/2022", "AFTERNOON", 22, 2);
        //    WorkShift workShift1 = new WorkShift(1, "rawan", "22/12/2021", "AFTERNOON", 22, 2);
        //    MockWorkshiftMediator mock = new MockWorkshiftMediator();
        //    ShiftManager shift = new ShiftManager(mock);
        //    //act
        //    shift.AddWorkshift(workShift);
        //    shift.AddWorkshift(workShift1);
        //    num = shift.PreviousMonth(1, DateTime.Now.Month, DateTime.Now.Year).Count;
        //    //assert
        //    Assert.AreEqual(1, num);
        //}
    }
}
