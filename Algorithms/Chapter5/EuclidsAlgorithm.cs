using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olmelabs.Algorithms.Chapter5
{
    /// <summary>
    /// Program 5.3. Euclid's algorithm
    /// </summary>
    public class EuclidsAlgorithm
    {

        public int Gcd(int m, int n)
        {
            if (n == 0)
                return m;

            return Gcd(n, m % n);
        }
    }
}
