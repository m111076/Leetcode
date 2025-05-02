using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0713_Subarray_Product_Less_Than_K
    {
        //runtime 75%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;

            var left = 0;
            var right = 0;
            var result = 0;
            var product = 1;

            while (right < nums.Length)
            {
                product *= nums[right];

                while (product >= k)
                {
                    product /= nums[left++];
                }

                result += right - left + 1;
                right++;
            }

            return result;
        }
    }
}
