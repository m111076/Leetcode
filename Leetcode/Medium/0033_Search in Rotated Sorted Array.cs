using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0033_Search_in_Rotated_Sorted_Array
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        //可以先做153再來做這題
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                    left = mid + 1;
                else
                    right = mid;
            }

            var minIdx = left;

            if (target > nums[^1])
            {
                left = 0;
                right = minIdx;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;
                    if (nums[mid] < target)
                        left = mid + 1;
                    else
                        right = mid;
                }

                return nums[left] == target ? left : -1;
            }
            else
            {
                left = minIdx;
                right = nums.Length - 1;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;
                    if (nums[mid] < target)
                        left = mid + 1;
                    else
                        right = mid;
                }

                return nums[left] == target ? left : -1;
            }
        }
    }
}
