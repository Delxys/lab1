using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace NaboveZero
{
    [TestClass]
    public class TestNaboveZero
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            double b = 100;
            int p = -10;
            Trap Trap2 = new Trap();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Trap2.Count(p,a,b));
        }
    }
}
