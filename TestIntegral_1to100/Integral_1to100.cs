using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace TestIntegral_1to100
{
    [TestClass]
    public class Integral_1to100
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double a = 1;
            double b = 100;
            double true_res = 155494.861;
            int n = 1000000;
            Trap trap1 = new Trap();
            //Act
            Func<double, double> x = y => trap1.Count(n, a, b);
            //Assert
            double mycount = x(n);
            Assert.AreEqual(true_res, mycount, 1);
        }
    }
}
