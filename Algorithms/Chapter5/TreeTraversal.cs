using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Preorder, where we visit the node, then visit the left and right subtrees
/// Inorder, where we visit the left subtree, then visit the node, then visit the right subtree
/// Postorder, where we visit the left and right subtrees, then visit the node
/// </summary>
namespace Olmelabs.Algorithms.Chapter5
{
    public class TreeNode<T>
    {
        public TreeNode(T node)
        {
            Node = node;
        }

        public TreeNode(T node, TreeNode<T> left, TreeNode<T> right)
        {
            Node = node;
            Left = left;
            Right = right;
        }

        public T Node;

        public TreeNode<T> Left;

        public TreeNode<T> Right;

        public override string ToString()
        {
            return Node.ToString();
        }
    }

    /// <summary>
    /// Program 5.14. Recursive tree traversal
    /// </summary>
    /// <typeparam name="T">class</typeparam>
    public class TreeTraversal<T> where T: class
    {
        public void TraverseRecursive(TreeNode<T> root, string space = "")
        {
            if (root == null)
                return;

            //visit
            Trace.WriteLine($"{space}{root.ToString()}");

            TraverseRecursive(root.Left, space + "  ");
            TraverseRecursive(root.Right, space + "  ");
        }

        /// <summary>
        /// Program 5.15. Preorder traversal (nonrecursive)
        /// </summary>
        /// <param name="root"></param>
        public void TraverseWithStack(TreeNode<T> root)
        {
            if (root == null)
                return;

            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode<T> node = stack.Pop();

                //visit
                Trace.WriteLine($"{node.ToString()}");

                if (node.Right != null)
                    stack.Push(node.Right);

                if (node.Left != null)
                    stack.Push(node.Left);
            }
        }

        /// <summary>
        /// Program 5.16. Level-order traversal
        /// </summary>
        /// <param name="root"></param>
        public void TraverseWithQueue(TreeNode<T> root)
        {
            if (root == null)
                return;

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode<T> node = queue.Dequeue();

                //visit
                Trace.WriteLine($"{node.ToString()}");

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }


        /// <summary>
        /// Program 5.17. Computation of tree parameters
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Count(TreeNode<T> root)
        {
            if (root == null)
                return 0;

            return Count(root.Left) + Count(root.Right) + 1;
        }

        /// <summary>
        /// Program 5.17. Computation of tree parameters
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Height(TreeNode<T> root)
        {
            if (root == null)
                return -1;

            int lh = Height(root.Left);
            int rh = Height(root.Right);

            return lh > rh ? lh + 1 : rh + 1;
        }
    }
}
