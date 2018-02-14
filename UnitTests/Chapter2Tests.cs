using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter2;


namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter2Tests
    {
        [TestMethod]
        public void CounterTest()
        {
            //N: 10, Time: 0 ms
            //N: 100, Time: 2 ms
            //N: 1000, Time: 2706 ms
            //N: 10000, Time: 2590731 ms ~ 43.178 min

            Counter t = new Counter();
            t.DoCount(10);
            t.DoCount(100);
            t.DoCount(1000);
            //t.DoCount(10000);
        }
    }
}
