using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0704_Binary_Search
    {
        //runteim 100%
        //time complexity O(logn)
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}
