
using System;
using System.Diagnostics;

namespace Olmelabs.Algorithms.Chapter3
{
    /// <summary>
    /// Program 3.11. List insertion sort
    /// </summary>
    public class LinkedListInsertionSort
    {
        public LinkedListNode BuildList(int n)
        {
            var rnd = new Random();
            var a = new LinkedListNode(0, null);
            LinkedListNode t = a;

            for (int i = 2; i <= n; i++)
            {
                t = (t.Next = new LinkedListNode(rnd.Next(1, 100), null));
            }

            return a;
        }

        public object SortList(LinkedListNode a)
        {
            Trace.WriteLine($"Unsorted List {a}");

            LinkedListNode u;
            var b = new LinkedListNode(0, null);

            for (var t = a.Next; t != null; t = u)
            {
                u = t.Next;

                LinkedListNode x;
                for (x = b; x.Next != null; x = x.Next)
                {
                    if(x.Next.Item > t.Item)
                        break;
                }
                t.Next = x.Next;
                x.Next = t;
            }

            Trace.WriteLine($"Sorted List {b}");

            return b;
        }
    }
}
