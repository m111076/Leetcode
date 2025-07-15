using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3201_Find_the_Maximum_Length_of_Valid_Subsequence_I
    {
        public int MaximumLength(int[] nums)
        {
            var result = 0;

            for (var i = 0; i < 2; i++)
            {
                var dp = new int[2];
                foreach (var num in nums)
                {
                    var mod = num % 2;
                    var pre = (i - mod + 2) % 2;
                    dp[mod] = dp[pre] + 1;
                    result = Math.Max(result, dp[mod]);
                }
            }

            return result;
        }
    }
}
