using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2875_Minimum_Size_Subarray_in_Infinite_Array
    {
        //runtime 60%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        //須注意溢位問題
        public int MinSizeSubarray(int[] nums, int target)
        {
            var left = 0;
            var right = 0;
            var result = int.MaxValue;

            var sum = 0L;
            foreach (var i in nums)
            {
                sum += i;
            }

            var full = target / sum;
            var tmpSum = 0L;
            var length = nums.Length * 2;
            var target2 = target - sum * full;

            while (right < length)
            {
                tmpSum += nums[right % nums.Length];

                while (tmpSum > target2)
                {
                    tmpSum -= nums[left % nums.Length];
                    left++;
                }

                if (tmpSum == target2)
                    result = Math.Min(result, right - left + 1);

                right++;
            }

            return result == int.MaxValue ? -1 : result + (int)full * nums.Length;
        }
    }
}
