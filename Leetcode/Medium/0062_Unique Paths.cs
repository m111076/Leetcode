using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0062_Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            //runtime 100%
            //time complexity O(m*n)
            //space complexity O(m*n)
            var dp = new int[m + 1, n + 1];
            dp[0, 1] = 1;

            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m, n];

            //runtime 100%
            //time complexity O(m)
            //space complexity O(1)
            //數學公式
            //var cUP = (long)m - 1 + n - 1;
            //var cDown = Math.Min(m - 1, n - 1);
            //var result = 1L;

            //for (long i = 1; i <= cDown; i++)
            //{
            //    result = result * (cUP + 1 - i) / i;
            //}

            //return (int)result;
        }
    }
}
