using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace AaboveZero
{
    [TestClass]
    public class AaboveZero
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = -10;
            double b = 100;
            int p = 1000;
            Trap Trap2 = new Trap();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Trap2.Count(p, a, b));
        }
    }
}
