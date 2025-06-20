using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0279_Perfect_Squares
    {
        //runtime 88%
        //time complexity O(n * sqrt(n))
        //space complexity O(n)
        //動態規劃題目
        //從2開始逐一到達每個數字時的所需的最少平方數數量
        public int NumSquares(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                dp[i] = int.MaxValue;

                for (var j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }

            return dp[n];
        }
    }
}
