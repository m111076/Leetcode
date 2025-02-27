using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0053_Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            //runtime 100%
            //Kadane algorithm
            var result = nums[0];
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
                result = Math.Max(result, sum);

                if (sum < 0)
                    sum = 0;
            }

            return result;
        }
    }
}
