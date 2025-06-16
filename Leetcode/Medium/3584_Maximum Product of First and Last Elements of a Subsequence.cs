using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3584_Maximum_Product_of_First_and_Last_Elements_of_a_Subsequence
    {
        //runtime 68%
        //time complexity O(n)
        //space complexity O(n)
        public long MaximumProduct(int[] nums, int m)
        {
            var minArray = new int[nums.Length];
            var maxArray = new int[nums.Length];
            minArray[^1] = nums[^1];
            maxArray[^1] = nums[^1];

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                minArray[i] = Math.Min(minArray[i + 1], nums[i]);
                maxArray[i] = Math.Max(maxArray[i + 1], nums[i]);
            }

            var result = long.MinValue;

            for (var i = 0; i <= nums.Length - m; i++)
            {
                var min = minArray[i + m - 1];
                var max = maxArray[i + m - 1];
                result = Math.Max(result, (long)nums[i] * min);
                result = Math.Max(result, (long)nums[i] * max);
            }

            return result;
        }
    }
}
