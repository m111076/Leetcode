using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _70_Climbing_Stairs
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public static int ClimbStairs(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
