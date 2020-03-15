using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace NaboveZero
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestN()
        {
            int p = -10;
            Trap Trap2 = new Trap();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Trap2.Count(p));
        }
    }
}
