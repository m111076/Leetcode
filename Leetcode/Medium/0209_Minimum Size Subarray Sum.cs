using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0209_Minimum_Size_Subarray_Sum
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MinSubArrayLen(int target, int[] nums)
        {
            var left = 0;
            var right = 0;
            var result = int.MaxValue;
            var tmpSum = 0;

            while (right < nums.Length)
            {
                tmpSum += nums[right];

                while (tmpSum >= target)
                {
                    result = Math.Min(result, right - left + 1);
                    tmpSum -= nums[left++];
                }

                right++;
            }

            return result == int.MaxValue ? 0 : result;
        }
    }
}
