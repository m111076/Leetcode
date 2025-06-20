using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0198_House_Robber
    {
        //runtime 100%
        //DP問題
        //建立DP[i]表儲存前i個選擇時可偷到的最多錢
        //當選擇i時 其必不可能偷第i-1個，所以必定是選擇i-2的值
        //之後比較DP[i] = Max(nums[i]+DP[i-2],DP[i-1])
        public int Rob(int[] nums)
        {
            var dp = new int[nums.Length + 1];

            for (var i = 1; i <= nums.Length; i++)
            {
                if (i == 1)
                {
                    dp[i] = nums[i - 1];
                }
                else
                {
                    dp[i] = Math.Max(nums[i - 1] + dp[i - 2], dp[i - 1]);
                }
            }

            return dp[^1];
        }
    }
}
