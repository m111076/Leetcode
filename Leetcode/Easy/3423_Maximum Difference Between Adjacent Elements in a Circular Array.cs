using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3423_Maximum_Difference_Between_Adjacent_Elements_in_a_Circular_Array
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MaxAdjacentDistance(int[] nums)
        {
            var result = int.MinValue;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                result = Math.Max(result, Math.Abs(nums[i] - nums[i + 1]));
            }

            result = Math.Max(result, Math.Abs(nums[^1] - nums[0]));

            return result;
        }
    }
}
