using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter3;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter3Tests
    {
        [TestMethod]
        public void SieveOfEratosthenesTest()
        {
            //N: 10, Time: 0 ms
            //N: 100, Time: 2 ms
            //N: 1000, Time: 2706 ms
            //N: 10000, Time: 2590731 ms ~ 43.178 min

            SieveOfEratosthenes t = new SieveOfEratosthenes(30);
            t.DoSieve();
        }

        [TestMethod]
        public void CoinFlippingTest()
        {
            CoinFlipping t = new CoinFlipping(50, 1000);
            t.DoFlip();
        }

        [TestMethod]
        public void JosephusProblemTest()
        {
            JosephusProblem t = new JosephusProblem(9, 5);
            t.KillThemAll();
        }

        [TestMethod]
        public void LinkedListReversalTest()
        {
            LinkedListReversal t = new LinkedListReversal();

            var x = t.BuildList(5);
            Assert.AreEqual(x.ToString(), "1 -> 2 -> 3 -> 4 -> 5");


            var r = t.ReverseList(x);
            Assert.AreEqual(r.ToString(), "5 -> 4 -> 3 -> 2 -> 1");
        }

        [TestMethod]
        public void LinkedListInsertionSort()
        {
            LinkedListInsertionSort t = new LinkedListInsertionSort();

            var x = t.BuildList(5);
            var r = t.SortList(x);
        }
    }
}
