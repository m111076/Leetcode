using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0034_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        //Binary Search close section
        public int[] SearchRange(int[] nums, int target)
        {
            var start = LowerBound(nums, target);
            if (start == nums.Length || nums[start] != target)
                return new int[] { -1, -1 };

            var end = LowerBound(nums, target + 1) - 1;
            return new int[] { start, end };
        }

        public int LowerBound(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] >= target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
