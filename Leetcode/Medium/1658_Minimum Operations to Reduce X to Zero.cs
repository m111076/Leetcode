using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1658_Minimum_Operations_to_Reduce_X_to_Zero
    {
        //runtime 74%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        //計算nums的和減去x的值(target)
        //透過滑動視窗找出subArray元素和等同於target
        //nums長度減去subArray極為解
        public int MinOperations(int[] nums, int x)
        {
            var left = 0;
            var right = 0;
            var result = int.MinValue;
            var target = nums.Sum() - x;
            var tmpSum = 0;

            if (target == 0)
                return nums.Length;

            if (target < 0)
                return -1;

            while (right < nums.Length)
            {
                tmpSum += nums[right];

                while (tmpSum > target)
                {
                    tmpSum -= nums[left++];
                }

                if (tmpSum == target)
                    result = Math.Max(result, right - left + 1);

                right++;
            }

            return result == int.MinValue ? -1 : nums.Length - result;
        }
    }
}
