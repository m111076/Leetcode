using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2419_Longest_Subarray_With_Maximum_Bitwise_AND
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int LongestSubarray(int[] nums)
        {
            var max = 0;
            var result = 0;
            var tmpLength = 0;

            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                    tmpLength = 1;
                    result = 1;
                }
                else if (num == max)
                {
                    tmpLength++;
                    result = Math.Max(result, tmpLength);
                }
                else
                {
                    tmpLength = 0;
                }
            }

            return result;
        }
    }
}
