using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifyString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifyString.Tests
{
    [TestClass()]
    public class StringCharRemoveTests
    {
        [TestMethod()]
        public void CleanstringTest()
        {
            //Assert.Fail();
            StringCharRemove objRemoveSpecialChar = new StringCharRemove();
            string actual=objRemoveSpecialChar.Cleanstring("ab!*#ca");
            Assert.AreEqual("abca", actual);
        }
    }
}