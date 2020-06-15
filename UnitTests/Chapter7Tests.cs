using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter7;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter7Tests
    {
        string[] _items;
        string[] _sortedItems;
        [TestInitialize]
        public void TestInit()
        {
            _items = new string[] { "A", "S", "O", "R", "T", "I", "N", "G", "E", "X", "A", "M", "P", "L", "E" };
            _sortedItems = new string[] { "A", "A", "E", "E", "G", "I", "L", "M", "N", "O", "P", "R", "S", "T", "X" };
        }

        [TestMethod]
        public void QuickSort()
        {
            QuickSort<string> s = new QuickSort<string>();
            s.Sort(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }


        [TestMethod]
        public void QuickSortNonRecursive()
        {
            QuickSort<string> s = new QuickSort<string>();
            s.SortNonRecursive(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }
    }
}
