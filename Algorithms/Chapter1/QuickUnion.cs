using System;
using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter1
{
    /// <summary>
    /// Program 1.2. Quick-union solution to connectivity problem
    /// M - number of pairs.
    /// MN/2 or more complexity. 
    /// </summary>
    public class QuickUnion
    {
        private readonly int _n;
        private readonly int[] _id;

        public QuickUnion(int n)
        {
            _n = n;
            _id = new int[_n];
            for (int i = 0; i < _n; i++)
            {
                _id[i] = i;
            }
        }

        public int[] DoSearch(int[][] pqPairs)
        {
            foreach (var pqPair in pqPairs)
            {
                CheckArgs(pqPair);

                Trace.Write($"{pqPair[0]} - {pqPair[1]}     ");

                int p = pqPair[0];
                int q = pqPair[1];

                int i;
                int j;

                for (i = p; i != _id[i]; i = _id[i])
                {
                     //Trace.WriteLine($"  i = {i}");
                }
                for (j = q; j != _id[j]; j = _id[j])
                {
                    //Trace.WriteLine($"  j = {j}");
                }

                if (i == j)
                {
                    Trace.WriteLine($"{string.Join(",", _id.Select(z => z))}");
                    continue;
                }

                _id[i] = j;
                Trace.WriteLine($"{string.Join(",", _id.Select(z => z))}");
            }

            return _id;
        }

        private void CheckArgs(int[] pqPair)
        {
            if (pqPair.Length != 2)
                throw new ArgumentException("Pair should contain only 2 integers");

            if (pqPair[0] > _n || pqPair[1] > _n)
                throw new ArgumentException($"There is an int which is greater than Max {_n}. Pair [{pqPair[0]} - {pqPair[1]}] ");
        }
    }
}
