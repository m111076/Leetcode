using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0643_Maximum_Average_Subarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var sum = 0;
            var max = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (i < k - 1)
                    continue;

                max = Math.Max(max, sum);

                sum -= nums[i - k + 1];
            }

            return (double)max / k;
        }
    }
}
