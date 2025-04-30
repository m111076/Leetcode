using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2090_K_Radius_Subarray_Averages
    {
        //runtime 67%
        //time complexity O(n)
        //space complexity O(n)
        //滑動視窗
        public int[] GetAverages(int[] nums, int k)
        {
            var sum = 0L;
            var result = Enumerable.Repeat(-1, nums.Length).ToArray();

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (i < k * 2)
                {
                    result[i] = -1;
                    continue;
                }

                result[i - k] = (int)(sum / (k * 2 + 1));

                sum -= nums[i - k * 2];
            }

            return result;
        }
    }
}
