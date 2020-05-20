using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_tests
{
    [TestClass]
    public class Lab1_tests
    {
        [TestMethod]
        public async Task Integral_1to100simp()
        {
            //Arrange
            double a = 1;
            double b = 100;
            double true_res = 155494.861;
            int n = 1000000;
            Simpson simp1 = new Simpson();
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            //Act
            double mycount = await simp1.Count(n, a, b, token, progress, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }
        [TestMethod]
        public async Task Integral_20to50simp()
        {
            //Arrange
            double a = 20;
            double b = 50;
            double true_res = 32243.51907;
            int n = 1000000;
            Simpson simp1 = new Simpson();
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            //Act
            double mycount =await simp1.Count(n, a, b, token, progress, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task AlessThanZero()
        {
            double a = -10;
            double b = 100;
            int n = 1000;
            Trap Trap2 = new Trap();
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            double actual = await Trap2.Count(n, a, b, token, progress, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task NlessThanZero()
        {
            double a = 1;
            double b = 100;
            int n = -10;
            Trap Trap2 = new Trap();
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            double actual =await Trap2.Count(n, a, b, token, progress, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
        }
        [TestMethod]
        public async Task Integral_1to100trap()
        {
            //Arrange
            double a = 1;
            double b = 100;
            double true_res = 155494.861;
            int n = 1000000;
            Trap trap1 = new Trap();
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            //Act
            double mycount = await trap1.Count(n, a, b, token, progress, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            //Assert
            Assert.AreEqual(true_res, mycount, 1);
        }
    }
}
