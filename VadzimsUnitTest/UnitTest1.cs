using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VadzimsUnitTest
{
    [TestClass]
    [TestCategory ("Quiz")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod11()
        {
            var a = 1;
            Assert.AreEqual(2, a + a);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.Fail("this will always fail");
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
