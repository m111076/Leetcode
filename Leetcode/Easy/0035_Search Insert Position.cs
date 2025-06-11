using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _35_Search_Insert_Position
    {
        public static int SearchInsert(int[] nums, int target)
        {
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == target)
            //        return i;
            //    else if (nums[i] > target)
            //    {
            //        return i;
            //    }
            //    else if (target > nums[i] && i == nums.Length - 1)
            //    {
            //        return i + 1;
            //    }

            //}

            //return default;
            //runtime 100%
            //time complexity O(logN)
            //var left = 0;
            //var right = nums.Length - 1;

            //while (left <= right)
            //{
            //    var mid = left + (right - left) / 2;

            //    if (nums[mid] == target)
            //        return mid;
            //    else if (nums[mid] > target)
            //        right = mid - 1;
            //    else
            //        left = mid + 1;
            //}

            //return left;

            var left = 0;
            var right = nums.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
