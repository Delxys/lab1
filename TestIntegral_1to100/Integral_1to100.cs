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
            double mycount = trap1.Count(n, a, b);
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }
    }
}
