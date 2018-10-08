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


        [TestMethod]
        public void DrawARuler()
        {
            DrawARuler c = new DrawARuler();
            c.Rule(0, 8, 3);
            c.RuleNonRecursive(0, 8, 3);
        }

        [TestMethod]
        public void Fibonacci()
        {
            Fibonacci f = new Fibonacci();
            //int res1 = f.F(6);
            int res2 = f.F_Dynamic(6);
        }

        [TestMethod]
        public void TreeTraverseRecursive()
        {
            TreeNode<string> root = BuildTree();

            TreeTraversal<string> t = new TreeTraversal<string>();
            t.TraverseRecursive(root);
        }

        [TestMethod]
        public void TreeTraverseWithStack()
        {
            TreeNode<string> root = BuildTree();

            TreeTraversal<string> t = new TreeTraversal<string>();
            t.TraverseWithStack(root);
        }

        [TestMethod]
        public void TreeTraverseWithQueue()
        {
            TreeNode<string> root = BuildTree();

            TreeTraversal<string> t = new TreeTraversal<string>();
            t.TraverseWithQueue(root);
        }

        [TestMethod]
        public void TreeNodeCount()
        {
            TreeNode<string> root = BuildTree();

            TreeTraversal<string> t = new TreeTraversal<string>();
            int res = t.Count(root);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void TreeHeight()
        {
            TreeNode<string> root = BuildTree();

            TreeTraversal<string> t = new TreeTraversal<string>();
            int res = t.Height(root);

            Assert.AreEqual(3, res);
        }

        private TreeNode<string> BuildTree()
        {
            TreeNode<string> n = new TreeNode<string>("E",
                new TreeNode<string>("D",
                    new TreeNode<string>("B",
                        new TreeNode<string>("A"),
                        new TreeNode<string>("C")
                        ),
                    null
                ),
                new TreeNode<string>("H",
                    new TreeNode<string>("F",
                        null,
                        new TreeNode<string>("G")),
                    null
                )
            );
            return n;
        }
    }
}