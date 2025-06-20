using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0322_Coin_Change
    {
        public int CoinChange(int[] coins, int amount)
        {
            //runtime 85%
            //time complexity O(n*m)
            //space complexity O(n)
            var dp = new int[amount + 1];
            dp[0] = 0;

            for (var i = 1; i <= amount; i++)
            {
                dp[i] = amount + 1;
                foreach (var coin in coins)
                {
                    if (i - coin >= 0)
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }

            return dp[^1] > amount ? -1 : dp[^1];
        }
    }
}
