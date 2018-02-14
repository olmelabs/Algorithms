using System;
using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter3.Arrays
{
    /// <summary>
    /// Program 3.7. Coin-flipping simulation
    /// N - times coin flipped
    /// M - number of experiments
    /// </summary>
    public class CoinFlipping
    {
        private readonly Random _rnd;
        private readonly int _n;
        private readonly int _m;
        private readonly int[] _arr;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">times coin flipped</param>
        /// <param name="m">number of experiments</param>
        public CoinFlipping(int n, int m)
        {
            _rnd = new Random();

            _n = n;
            _m = m;
            _arr = new int[_n + 1];
            for (int j = 0; j < _n; j++)
            {
                _arr[j] = 0;
            }
        }

        public void DoFlip()
        {
            int i, j, cnt;

            for (i = 0; i < _m; i++, _arr[cnt]++)
            {
                for (cnt = 0, j = 0; j <= _n; j++)
                {
                    if (Heads())
                    {
                        cnt++;
                    }
                }
            }

            Trace.WriteLine("");
            for (j = 0; j <= _n; j++)
            {
                if (_arr[j] == 0)
                {
                    Trace.Write(".");
                }
                for (i = 0; i < _arr[j]; i += 10)
                {
                    Trace.Write("*");
                }
                Trace.WriteLine("");
            }

        }

        private bool Heads()
        {
            return _rnd.Next() < int.MaxValue / 2;
        }

    }
}
