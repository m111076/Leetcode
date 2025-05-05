using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0790_Domino_and_Tromino_Tiling
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //重點在找規律
        public int NumTilings(int n)
        {
            if (n == 1) return 1;

            var dp = new long[n + 1];
            var mod = 1000000007;

            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = (2 * dp[i - 1] + dp[i - 3]) % mod;
            }

            return (int)dp[n];
        }
    }
}
