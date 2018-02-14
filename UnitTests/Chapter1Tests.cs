using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter1;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter1Tests
    {
        [TestMethod]
        public void QuickFindTest()
        {
            var pqPairs = CreatePairs();

            var qf = new QuickFind(10);

            int[] arr = qf.DoSearch(pqPairs);

            //all items are now connected - all indexes are 1
            Assert.IsFalse(arr.Any(i => i != 1));
        }


        [TestMethod]
        public void QuickUnionTest()
        {
            var pqPairs = CreatePairs();

            var qu = new QuickUnion(10);
            qu.DoSearch(pqPairs);


            //all items are now connected - all indexes are 1
            //Assert.IsFalse(arr.Any(i => i != 1));
        }


        [TestMethod]
        public void WeightedQuickUnionTest()
        {
            var pqPairs = CreatePairs();

            var wqu = new WeightedQuickUnion(10);
            wqu.DoSearch(pqPairs);

            //all items are now connected - all indexes are 1
            //Assert.IsFalse(arr.Any(i => i != 1));
        }

        private static int[][] CreatePairs()
        {
            int[] pq1 = { 3, 4 };
            int[] pq2 = { 4, 9 };
            int[] pq3 = { 8, 0 };
            int[] pq4 = { 2, 3 };
            int[] pq5 = { 5, 6 };
            int[] pq6 = { 2, 9 };
            int[] pq7 = { 5, 9 };
            int[] pq8 = { 7, 3 };
            int[] pq9 = { 4, 8 };
            int[] pq10 = { 5, 6 };
            int[] pq11 = { 0, 2 };
            int[] pq12 = { 6, 1 };
            int[] pq13 = { 5, 8 };

            return new[] { pq1, pq2, pq3, pq4, pq5, pq6, pq7, pq8, pq9, pq10, pq11, pq12, pq13 };
        }
    }
}
