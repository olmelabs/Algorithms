using System;
using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter1
{
    /// <summary>
    /// Program 1.3. Weighted version of quick union
    /// Program 1.4. Path compression by halving
    /// M - number of pairs.
    /// M lg (N) complexity
    /// </summary>
    public class WeightedQuickUnion
    {
        private readonly int _n;
        private readonly int[] _id;
        private readonly int[] _sz;


        public WeightedQuickUnion(int n)
        {
            _n = n;
            _id = new int[_n];
            _sz = new int[_n];

            for (int i = 0; i < _n; i++)
            {
                _id[i] = i;
                _sz[i] = 1;
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
                    //weighted quick union with path compression by halving
                    //_id[i] = _id[_id[i]];
                }
                for (j = q; j != _id[j]; j = _id[j])
                {
                    //weighted quick union with path compression by halving
                   // _id[j] = _id[_id[j]];
                }

                if (i == j)
                {
                    Trace.WriteLine($"{string.Join(",", _id.Select(z => z))}");
                    continue;
                }

                if (_sz[i] < _sz[j])
                {
                    _id[i] = j;
                    _sz[j] += _sz[i];
                }
                else
                {
                    _id[j] = i;
                    _sz[i] += _sz[j];
                }

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
