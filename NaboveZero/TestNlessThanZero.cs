using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace NlessThanZero
{
    [TestClass]
    public class TestNlessThanZero
    {
        [TestMethod]
        public void NlessThanZero()
        {
            double a = 1;
            double b = 100;
            int n = -10;
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
