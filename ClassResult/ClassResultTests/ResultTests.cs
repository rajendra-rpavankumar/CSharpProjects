using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassResult.Tests
{
    [TestClass()]
    public class ResultTests
    {
        Result testobj = null;

        [TestInitialize]
        public void Initialize()
        {
            testobj = new Result();
        }

        [TestMethod()]
        public void FindRankTest()
        {
            //Assert.Fa9il();
            //Assert.Fail("Distinction");
            //Result obj = new Result();
            Assert.AreEqual("Distinction", testobj.FindRank(100));
        }

        [TestMethod()]
        public void CheckFirstclass()
        {
            Assert.AreEqual("First",testobj.FindRank(75));
        }

        [TestMethod()]
        public void CheckSecondclass()
        {
            Assert.AreEqual("Second", testobj.FindRank(55));
        }

        [TestMethod()]
        public void CheckPass()
        {
            Assert.AreEqual("Pass", testobj.FindRank(45));
        }

        [TestMethod()]
        public void CheckFail()
        {
            Assert.AreEqual("Fail", testobj.FindRank(30));
        }

        [TestMethod()]
        public void CheckFailForNegative()
        {
            Assert.AreEqual("Not Valid", testobj.FindRank(-1));
        }
    }
}