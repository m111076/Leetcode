using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0837_New_21_Game
    {
        //runtime 85%
        //time complexity O(n)
        //space complexity O(n)
        public double New21Game(int n, int k, int maxPts)
        {
            var dp = new double[n + 1];
            var sum = 0d;

            for (var i = n; i >= 0; i--)
            {
                if (i >= k)
                    dp[i] = 1;
                else
                    dp[i] = sum / maxPts;

                sum += dp[i];

                if (i + maxPts <= n)
                    sum -= dp[i + maxPts];
            }

            return dp[0];
        }
    }
}
