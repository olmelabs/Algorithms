using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter3.Arrays;

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
    }
}
