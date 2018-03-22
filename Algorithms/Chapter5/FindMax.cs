
using System;
using System.Diagnostics;

namespace Olmelabs.Algorithms.Chapter5
{
    public class FindMax
    {
        public int[] CreateArray(int n)
        {
            int[] a = new int[n+1];
            Random rnd = new Random();

            for (int i = 0; i <= n; i++)
            {
                a[i] = rnd.Next(100);
            }

            return a;
        }

        public int Max(int[] array, int l, int r, string space = null)
        {
            Trace.WriteLine($"{space}MaxImpl({l}, {r})");

            if (l == r) return array[l];
            int m = (l + r) / 2;
            int u = Max(array, l, m, space + "  ");
            int v = Max(array, m + 1, r, space + "  ");
            if (u > v) return u; else return v;
        }
    }
}
