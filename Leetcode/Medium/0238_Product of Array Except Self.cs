using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0238_Product_of_Array_Except_Self
    {
        //runtime 73%
        //time complexity O(n)
        //space complexity O(n)
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            var right = new int[nums.Length];
            var left = new int[nums.Length];

            left[0] = 1;
            right[^1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
                right[^(i + 1)] = right[^i] * nums[^i];
            }


            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = left[i] * right[i];
            }

            return result;
        }
    }
}
