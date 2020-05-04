using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Integral_1to100simp
{
    [TestClass]
    public class TestIntegral_1to100simp
    {
        [TestMethod]
        public void Integral_1to100simp()
        {
            //Arrange
            double a = 1;
            double b = 100;
            double true_res = 155494.861;
            int n = 1000000;
            Simpson simp1 = new Simpson();
            //Act
            double mycount = simp1.Count(n, a, b, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }
    }
}
