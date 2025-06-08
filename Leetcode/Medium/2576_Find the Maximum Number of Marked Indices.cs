using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _2576_Find_the_Maximum_Number_of_Marked_Indices
    {
        //runtime 24.43%
        //time complexity O(nlogn)
        //space complexity O(1)
        //左閉右開 區間條件要確認好
        //也可使用check內部的判斷條件直接求解
        public static int MaxNumOfMarkedIndices(int[] nums)
        {
            var left = 0;
            var right = nums.Length / 2 + 1;
            Array.Sort(nums);

            while (left < right)
            {
                var mid = (left + right) / 2;
                if (!Check(nums, mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return (left - 1) * 2;
        }

        public static bool Check(int[] nums, int mid)
        {
            for (var i = 0; i < mid; i++)
            {
                if (2 * nums[i] > nums[nums.Length - mid + i])
                    return false;
            }

            return true;
        }
    }
}
