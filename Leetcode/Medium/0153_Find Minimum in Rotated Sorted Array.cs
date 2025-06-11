using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0153_Find_Minimum_in_Rotated_Sorted_Array
    {
        //runtime 100%
        //time complexity O(logn)
        //sapce complexity O(1)
        //用二分法找出第一個小於左邊數字的位置
        public int FindMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return nums[left];
        }
    }
}
