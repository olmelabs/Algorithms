using System;

namespace Olmelabs.Algorithms.Chapter6
{
    public class Sorting<T> where T : IComparable
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
        /// insertion nonadaptive sort
        /// Program 6.1. Example of array sort with driver program
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void InsertionSort(T[] items, int l, int r)
        {
            for (int i = l + 1; i <= r; i++)
            {
                for (int j = i; j > l; j--)
                {
                    CompareExchange(ref items[j - 1], ref items[j]);
                }
            }
        }

        /// <summary>
        /// Program 6.3. Insertion sort
        /// improvement over Program 6.1 because 
        /// (i) it first puts the smallest element in the array into the first position, so that that element can serve as a sentinel; 
        /// (ii) it does a single assignment, rather than an exchange, in the inner loop; and 
        /// (iii) it terminates the inner loop when the element being inserted is in position. 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void InsertionSort2(T[] items, int l, int r)
        {
            int i;
            for (i = r; i > l; i--)
            {
                CompareExchange(ref items[i - 1], ref items[i]);
            }

            for (i = l + 2; i <= r; i++)
            {
                int j = i;
                T v = items[i];
                while (v.CompareTo(items[j - 1]) < 0)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = v;
            }


        }

        /// <summary>
        /// Program 6.2. Selection sort. Complexity N^2
        ///  Selection sort uses about N^2/2 comparisons and N exchanges
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void SelectionSort(T[] items, int l, int r)
        {
            for (int i = l; i < r; i++)
            {
                int min = i;
                for (int j = i + 1; j <= r; j++)
                {
                    if (items[j].CompareTo(items[min]) < 0)
                    {
                        min = j;
                    }
                }
                Exchange(ref items[i], ref items[min]);
            }
        }

        /// <summary>
        /// Program 6.4. Bubble sort
        /// </summary>
        /// <param name="items"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void BubbleSort(T[] items, int l, int r)
        {
            for (int i = l; i < r; i++)
            {
                for (int j = r; j > i; j--)
                {
                    CompareExchange(ref items[j - 1], ref items[j]);
                }
            }
        }

        /// <summary>
        /// insertion nonadaptive sort
        /// Program 6.5. Shellsort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void ShellSort(T[] items, int l, int r)
        {
            int h;
            for (h = 1; h <= (r-l)/9; h = 3*h + 1);
            for (; h > 0; h /= 3)
            {
                for (int i = l + h; i <= r; i++)
                {
                    int j = i; T v = items[i];
                    while (j >= l + h && v.CompareTo(items[j - h]) < 0)
                    {
                        items[j] = items[j - h]; j -= h;
                    }
                    items[j] = v;
                }
            }
        }

    }
}
