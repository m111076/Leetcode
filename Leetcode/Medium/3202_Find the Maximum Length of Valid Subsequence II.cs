using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3202_Find_the_Maximum_Length_of_Valid_Subsequence_II
    {
        public int MaximumLength(int[] nums, int k)
        {
            var result = 0;

            for (var i = 0; i < k; i++)
            {
                var dp = new int[k];
                foreach (var num in nums)
                {
                    var mod = num % k;
                    var pre = (i - mod + k) % k;
                    dp[mod] = dp[pre] + 1;
                    result = Math.Max(result, dp[mod]);
                }
            }

            return result;
        }
    }
}
