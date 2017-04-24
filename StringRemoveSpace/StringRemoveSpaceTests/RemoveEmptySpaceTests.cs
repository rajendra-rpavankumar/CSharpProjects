using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringRemoveSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRemoveSpace.Tests
{
    [TestClass()]
    public class RemoveEmptySpaceTests
    {
        [TestMethod()]
        public void RemoveSpaceTest()
        {
            //Assert.Fail();
            RemoveEmptySpace objRemove = new RemoveEmptySpace();
            string output = objRemove.RemoveSpace("Hello   World");
            Assert.AreEqual("Hello World", output);
        }
    }
}