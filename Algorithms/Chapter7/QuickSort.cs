using System;
using System.Collections.Generic;

namespace Olmelabs.Algorithms.Chapter7
{
    public class QuickSort<T> where T : IComparable
    {
        private void Exchange(ref T A, ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }

        private void CompareExchange(ref T A, ref T B)
        {
            if (B.CompareTo(A) < 0)
                Exchange(ref A, ref B);
        }

        /// <summary>
        /// Program 7.1. Quicksort
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void Sort(T[] items, int l, int r)
        {
            if (r <= l) return;

            int i = Partition(items, l, r);

            Sort(items, l, i - 1);
            Sort(items, i + 1, r);
        }

        /// <summary>
        /// Program 7.2. Partitioning
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private int Partition(T[] items, int l, int r)
        {
            int i = l - 1, j = r; T v = items[r];
            for (; ; )
            {
                while (items[++i].CompareTo(v) < 0);

                while (v.CompareTo(items[--j]) < 0)
                {
                    if (j == l)
                    {
                        break;
                    }
                }
                if (i >= j)
                {
                    break;
                }
                Exchange(ref items[i], ref items[j]);
            }
            Exchange(ref items[i], ref items[r]);
            return i;
        }

        /// <summary>
        /// Program 7.3. Nonrecursive quicksort
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void SortNonRecursive (T[] items, int l, int r)
        {
            Stack<int> s = new Stack<int>();
            Push2(s, l, r);
            while (s.Count > 0)
            {
                l = s.Pop();
                r = s.Pop();
                if (r <= l)
                    continue;
                int i = Partition(items, l, r);
                if (i - 1 > r - i)
                {
                    Push2(s, l, i - 1);
                    Push2(s, i + 1, r);
                }
                {
                    Push2(s, i + 1, r);
                    Push2(s, l, i - 1);
                }
            }
        }

        private void Push2(Stack<int> s, int a, int b)
        {
            s.Push(b);
            s.Push(a);
        }

    }
}
