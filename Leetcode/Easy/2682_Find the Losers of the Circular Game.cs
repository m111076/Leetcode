using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //runtime 100%
    //time complexity O(n)
    internal static class _2682_Find_the_Losers_of_the_Circular_Game
    {
        public static int[] CircularGameLosers(int n, int k)
        {
            var p = new int[n];
            var target = 0;
            var use = 0;
            var run = 1;

            while (p[target] + 1 < 2)
            {
                if (p[target] == 0)
                    use++;
                p[target]++;
                target += run++ * k;
                target %= n;
            }

            var result = new int[n - use];
            var idx = 0;

            for (var i = 0; i < n; i++)
            {
                if (p[i] == 0)
                {
                    result[idx++] = i + 1;
                }
            }

            return result;
        }
    }
}
