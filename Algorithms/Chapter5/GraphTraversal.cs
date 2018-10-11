using System.Collections.Generic;
using System.Diagnostics;


namespace Olmelabs.Algorithms.Chapter5
{
    public class GraphNode<T>
    {
        public GraphNode(T item)
        {
            Item = item;
            ConnectedItems = new List<GraphNode<T>>();
        }

        public T Item;

        public bool IsVisisted;

        public List<GraphNode<T>> ConnectedItems;

        public override string ToString()
        {
            return Item.ToString();
        }
    }

    public class GraphTraversal<T>
    {
        /// <summary>
        /// Program 5.21. Depth-first search
        /// </summary>
        /// <param name="node"></param>
        public void Traverse(GraphNode<T> node)
        {
            //visit
            node.IsVisisted = true;
            Trace.WriteLine($"{node.ToString()}");

            foreach (GraphNode<T> cn in node.ConnectedItems)
            {
                if (cn.IsVisisted)
                    continue;

                Traverse(cn);
            }
        }


        /// <summary>
        /// Program 5.22. Breadth-first search
        /// </summary>
        /// <param name="n"></param>
        public void TraverseWithQueue(GraphNode<T> node)
        {
            if (node == null)
                return;

            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.IsVisisted)
                    continue;

                //visit
                node.IsVisisted = true;
                Trace.WriteLine($"{node.ToString()}");

                foreach (GraphNode<T> cn in node.ConnectedItems)
                {
                    if (cn.IsVisisted)
                        continue;

                    queue.Enqueue(cn);
                }
            }
        }

    }
}
