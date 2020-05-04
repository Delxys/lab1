using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Integral_20to50simp
{
    [TestClass]
    public class testIntegral_20to50simp
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double a = 20;
            double b = 50;
            double true_res = 32243.51907;
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
