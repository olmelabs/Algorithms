
using System.Diagnostics;

namespace Olmelabs.Algorithms.Chapter2
{
    /// <summary>
    /// Exercise 2.2
    /// </summary>
    public class Counter
    {
        public void DoCount(int n)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            int count = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        count++;

            st.Stop();
            Trace.WriteLine($"N: {n}, Time: {st.ElapsedMilliseconds} ms");
        }
    }
}
