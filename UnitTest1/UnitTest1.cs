using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double a = 1;
            double b = 100000;
            //                159996000024
            double true_res = 159991579534.684;
            int n = 100000;
            Trap trap1 = new Trap(a,b);
            double h = (b - a) / n;
            //Act
            Func<double, double> x = y => trap1.Count(n);
            //Assert
            double actual = x(n);
            Assert.AreEqual(true_res, actual, 0.1);
        }
    }
}
