using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2787_Ways_to_Express_an_Integer_as_Sum_of_Powers
    {
        public int NumberOfWays(int n, int x)
        {
            var mod = 1000000007;
            var dp = new long[n + 1];
            dp[0] = 1;

            for (var i = 1; Math.Pow(i, x) <= n; i++)
            {
                var target = (int)Math.Pow(i, x);
                for (var j = n; j >= target; j--)
                {
                    dp[j] += dp[j - target];
                }
            }

            return (int)(dp[n] % mod);
        }
    }
}
