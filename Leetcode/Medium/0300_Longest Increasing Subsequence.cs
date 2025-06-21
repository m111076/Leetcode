using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0300_Longest_Increasing_Subsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            //runtime 33%
            //time complexity O(n^2)
            //space complexity O(n)
            //動態規劃解法 較慢
            var dp = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;

                for (var j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }

            return dp.Max();
        }
    }
}
