using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0053_Maximum_Subarray
    {
        //runtime 100%k
        //time complexity O(n)
        //space complexity O(1)
        public int MaxSubArray(int[] nums)
        {
            var sum = 0;
            var result = int.MinValue;

            foreach (var n in nums)
            {
                sum += n;
                result = Math.Max(result, sum);

                if (sum < 0)
                {
                    sum = 0;
                }
            }

            return result;
        }
    }
}
