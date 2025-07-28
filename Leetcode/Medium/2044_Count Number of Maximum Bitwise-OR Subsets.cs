using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2044_Count_Number_of_Maximum_Bitwise_OR_Subsets
    {
        //runtime 100%
        //time complexity O(2^n)
        //space complexity O(2^n)
        public int CountMaxOrSubsets(int[] nums)
        {
            var max = 0;
            foreach (var num in nums)
            {
                max |= num;
            }
            var result = 0;
            var dp = new int[1 << nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var target = nums[i];
                var mask = 1 << i;
                for (var j = 0; j < mask; j++)
                {
                    var tmp = dp[j] | target;
                    dp[mask | j] = tmp;
                    if (tmp == max)
                        result++;
                }
            }
            return result;
        }
    }
}
