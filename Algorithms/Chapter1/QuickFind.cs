using System;
using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter1
{
    /// <summary>
    /// Program 1.1. Quick-find solution to connectivity problem
    /// M - number of pairs.
    /// M * N complexity.
    /// </summary>
    public class QuickFind
    {
        private readonly int _n;
        private readonly int[] _id;

        public QuickFind(int n)
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

                int p = pqPair[0];
                int q = pqPair[1];

                int t = _id[p];
                if (t == _id[q])
                    continue;

                for (int i = 0; i < _n; i++)
                {
                    if (_id[i] == t)
                        _id[i] = _id[q];
                }

                Trace.Write($"{pqPair[0]} - {pqPair[1]}     ");
                Trace.WriteLine($"{string.Join(",", _id.Select(i => i))}");
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
