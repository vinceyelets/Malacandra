using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VadzimsUnitTest
{
    [TestClass]
    [TestCategory("Part3")]
    public class VadzimsTest3
    {
        private int a, b;
        [TestInitialize]
        public void RunBeforeEveryTest()

        {
            a = 1;
            b = 1;
        }
        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in a class");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, a + a);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod13()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }

    }
}
