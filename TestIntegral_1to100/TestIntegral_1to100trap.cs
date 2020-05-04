using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Integral_1to100trap
{
    [TestClass]
    public class TestIntegral_1to100trap
    {
        [TestMethod]
        public void Integral_1to100trap()
        {
            //Arrange
            double a = 1;
            double b = 100;
            double true_res = 155494.861;
            int n = 1000000;
            Trap trap1 = new Trap();
            //Act
            double mycount = trap1.Count(n, a, b,(x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }
    }
}
