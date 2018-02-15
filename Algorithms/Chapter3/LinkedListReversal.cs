namespace Olmelabs.Algorithms.Chapter3
{
    /// <summary>
    /// Program 3.10. List reversal
    /// N - number of nodes in list
    /// </summary>
    public class LinkedListReversal
    {

        /// <summary>
        ///To reverse the order of a list, we maintain a pointer r to the portion of the list already processed, 
        ///and a pointer y to the portion of the list not yet seen. This diagram shows how the pointers change 
        ///for each node in the list. We save a pointer to the node following y in t, change y's link to point to r,
        ///and then move r to y and y to t.
        /// </summary>
        /// <param name="x">LinkedNode</param>
        /// <returns>reversed linked list</returns>
        public LinkedListNode ReverseList(LinkedListNode x)
        {
            LinkedListNode r = null;
            var y = x;

            while (y != null)
            {
                var t = y.Next;
                y.Next = r;
                r = y;
                y = t;
            }

            return r;
        }

        public LinkedListNode BuildList(int n)
        {
            var x = new LinkedListNode(1, null);
            LinkedListNode t = x;
            for (int i = 2; i <= n; i++)
            {
                LinkedListNode y = new LinkedListNode(i, null);
                t.Next = y;
                t = y;
            }
            return x;
        }
    }
}
