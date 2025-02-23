using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1800_Maximum_Ascending_Subarray_Sum
    {
        public int MaxAscendingSum(int[] nums)
        {
            var length = nums.Length;
            var maxSum = 0;
            var tempSum = nums[0];

            for (var i = 1; i < length; i++)
            {
                var target = nums[i];
                var sub = target - nums[i - 1];

                if (sub > 0)
                {
                    tempSum += target;
                }
                else
                {
                    maxSum = Math.Max(tempSum, maxSum);
                    tempSum = target;
                }
            }
            maxSum = Math.Max(tempSum, maxSum);

            return maxSum;
        }
    }
}
