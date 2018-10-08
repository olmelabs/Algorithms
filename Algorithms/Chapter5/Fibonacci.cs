using System.Diagnostics;

namespace Olmelabs.Algorithms.Chapter5
{
    public class Fibonacci
    {
        /// <summary>
        /// int F(int i)
        ///Program 5.10. Fibonacci numbers(recursive implementation). Exponential-time algorithm
        /// </summary>
        public int F(int i, string space = "")
        {
            Trace.WriteLine($"{space}{i}");

            if (i < 1)
                return 0;
            if (i == 1)
                return 1;
            return F(i - 1, space + "\t") + F(i - 2, space + "\t");
        }

        static int[] knownF = new int[1000];
        /// <summary>
        /// Program 5.11. Fibonacci numbers (dynamic programming)
        /// </summary>
        public int F_Dynamic(int i, string space = "")
        {
            if (knownF[i] != 0)
                return knownF[i];

            Trace.WriteLine($"{space}{i}");

            int t = i;
            if (i < 0)
                return 0;
            if (i > 1)
                t = F_Dynamic(i - 1, space + "\t") + F_Dynamic(i - 2, space + "\t");

            return knownF[i] = t;
        }
    }
}
