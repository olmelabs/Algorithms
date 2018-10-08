using System.Diagnostics;


namespace Olmelabs.Algorithms.Chapter5
{
    /// <summary>
    /// Program 5.8. Divide and conquer to draw a ruler
    /// Program 5.9. Nonrecursive program to draw a ruler
    /// </summary>
    public class DrawARuler
    {
    
        private void Mark(int m, int h)
        {
            Trace.WriteLine($"{m} - {h}");
        }

        public void Rule(int l, int r, int h)
        {
            int m = (l + r) / 2;
            if (h > 0)
            {
                Rule(l, m, h - 1);
                Mark(m, h);
                Rule(m, r, h - 1);
            }
        }

        public void RuleNonRecursive(int l, int r, int h)
        {
            for (int t = 1, j = 1; t <= h; j += j, t++)
                for (int i = 0; l + j + i <= r; i += j + j)
                    Mark(l + j + i, t);

        }
    }
}
