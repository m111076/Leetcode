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
            var start = Check(nums, target - 1);
            var end = Check(nums, target) - 1;

            if (start >= 0 && start < nums.Length && nums[start] == target)
                return new int[] { start, end };
            else
                return new int[] { -1, -1 };
        }

        public int Check(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
