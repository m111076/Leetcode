using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2411_Smallest_Subarrays_With_Maximum_Bitwise_OR
    {
        public int[] SmallestSubarrays(int[] nums)
        {
            var result = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                result[i] = 1;
                for (var j = i - 1; j >= 0 && (nums[j] | num) != nums[j]; j--)
                {
                    nums[j] |= num;
                    result[j] = i - j + 1;
                }
            }
            return result;
        }
    }
}
