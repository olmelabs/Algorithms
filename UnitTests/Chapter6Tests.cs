using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter6;


namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter6Tests
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
        public void InsertionSort()
        {
            Sorting<string> s = new Sorting<string>();
            s.InsertionSort(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }

        [TestMethod]
        public void InsertionSort2()
        {
            Sorting<string> s = new Sorting<string>();
            s.InsertionSort2(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }

        [TestMethod]
        public void SelectionSort()
        {
            Sorting<string> s = new Sorting<string>();
            s.SelectionSort(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }

        [TestMethod]
        public void BubbleSort()
        {
            Sorting<string> s = new Sorting<string>();
            s.BubbleSort(_items, 0, _items.Length - 1);

            CollectionAssert.AreEqual(_sortedItems, _items);
        }
    }
}
