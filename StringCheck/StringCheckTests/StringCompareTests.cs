using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheck.Tests
{
    [TestClass()]
    public class StringCompareTests
    {
        [TestMethod()]
        public void EqualStringTest()
        {
            StringCompare objCompare = new StringCompare();
            int output = objCompare.CompareString("aaa", "aaa");
            Assert.AreEqual(0, output);
        }

        [TestMethod()]
        public void NotEqualStringTest1()
        {
            StringCompare objCompare = new StringCompare();
            int output = objCompare.CompareString("aaa", "aaab");
            Assert.AreEqual(-1, output);
        }

        [TestMethod()]
        public void NotEqualStringTest2()
        {
            StringCompare objCompare = new StringCompare();
            int output = objCompare.CompareString("aaa", "ba");
            Assert.AreEqual(-1, output);
        }

        [TestMethod()]
        public void NotEqualStringTest3()
        {
            StringCompare objCompare = new StringCompare();
            int output = objCompare.CompareString("aaab", "aaa");
            Assert.AreEqual(1, output);
        }

        [TestMethod()]
        public void NotEqualStringTest4()
        {
            StringCompare objCompare = new StringCompare();
            int output = objCompare.CompareString("ba", "aaa");
            Assert.AreEqual(1, output);
        }
    }
}