using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace AlessThanZero
{
    [TestClass]
    public class TestAlessThanZero
    {
        [TestMethod]
        public void AlessThanZero()
        {
            double a = -10;
            double b = 100;
            int n = 1000;
            string exp = "Значение не попадает в ожидаемый диапазон.";
            Trap Trap2 = new Trap();
            double actual = Trap2.Count(n, a, b, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            Assert.AreEqual(exp, Trap2.ErrorInfo);
        }
    }
}
