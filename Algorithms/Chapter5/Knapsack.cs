using System;
using System.Collections.Generic;
using System.Linq;

namespace Olmelabs.Algorithms.Chapter5
{
    public class Knapsack
    {
        public class Item
        {
            public int size;
            public int val;
        }

        private List<Item> items;
        public Knapsack(List<Item> items)
        {
            this.items = items;
        }


        /// <summary>
        /// Complexity 2^n. Allows same item multiple times
        /// </summary>
        /// <param name="capacity">knapsack size</param>
        /// <returns>total value</returns>
        public int KnapSimple(int capacity)
        {
            int i, space, max, t;
            for (i = 0, max = 0; i < items.Count(); i++)
                if ((space = capacity - items[i].size) >= 0)
                    if ((t = KnapSimple(space) + items[i].val) > max)
                        max = t;
            return max;
        }

        /// <summary>
        /// Complexity 2^n. This does not allow to put same items into knapsack
        /// </summary>
        /// <param name="n"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int KnapSimple2(int n, int capacity)
        {
            int max;
            if (n < 0 || capacity <= 0)
            {
                max = 0;
            }
            else if (items[n].size > capacity)
            {
                max = KnapSimple2(n - 1, capacity);
            }
            else
            {
                int t1 = KnapSimple2(n - 1, capacity);
                int t2 = items[n].val + KnapSimple2(n - 1, capacity - items[n].size);
                max = Math.Max(t1, t2);
            }

            return max;
        }
    }
}
