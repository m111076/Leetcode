using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3627_Maximum_Median_Sum_of_Subsequences_of_Size_3
    {
        //runtime 48%
        //time complexity O(nlogn)
        //space complexity O(1)
        public long MaximumMedianSum(int[] nums)
        {
            var length = nums.Length;
            var b = length / 3;
            var result = 0L;

            Array.Sort(nums);

            for (int i = 1; i <= b; i++)
            {
                result += nums[length - i * 2];
            }

            return result;
        }
    }
}
