using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter5;
using System.Linq;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter5Tests
    {
        [TestMethod]
        public void EuclidsAlgorithm()
        {
            EuclidsAlgorithm c = new EuclidsAlgorithm();

            int res = c.Gcd(10, 8);
            Assert.AreEqual(2, res);

            res = c.Gcd(314159, 271828);
            Assert.AreEqual(1, res);

        }

        [TestMethod]
        public void FindMax()
        {
            FindMax c = new FindMax();
            int[] arr = c.CreateArray(10);
            int max = c.Max(arr, 0, arr.Length - 1);

            Assert.AreEqual(arr.Max(), max);
        }
    }
}