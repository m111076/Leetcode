using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2270_Number_of_Ways_to_Split_Array
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //用sum再轉型有可能在+的過程中 就先溢位了
        public static int WaysToSplitArray(int[] nums)
        {
            var sum = 0L;
            var pre = 0L;
            var result = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                pre += nums[i];

                if (pre >= sum - pre)
                    result++;
            }

            return result;
        }
    }
}
