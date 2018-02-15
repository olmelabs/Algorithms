using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter3
{
    /// <summary>
    /// Program 3.5. Sieve of Eratosthenes
    /// </summary>
    public class SieveOfEratosthenes
    {
        private readonly int _n;
        private readonly int[] _arr;
        public SieveOfEratosthenes(int n)
        {
            _n = n;
            _arr = new int[_n];
            for (int i = 0; i < _n; i++)
            {
                _arr[i] = 1;
            }
        }

        public void DoSieve()
        {
            Trace.WriteLine($"{string.Join(",", _arr.Select(z => z))}");

            for (int i = 2; i < _n; i++)
            {
                for (int j = i; j * i < _n; j++)
                {
                    _arr[i * j] = 0;
                }
                Trace.WriteLine($"{string.Join(",", _arr.Select(z => z))}");
            }
        }
    }
}
