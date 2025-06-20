using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0152_Maximum_Product_Subarray
    {
        public int MaxProduct(int[] nums)
        {
            //runtime 57%
            //time complexity O(n)
            //space complexity O(n)
            //space可以再壓縮成O(1)
            var minDP = new int[nums.Length];
            var maxDP = new int[nums.Length];
            var max = nums[0];

            minDP[0] = nums[0];
            maxDP[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxDP[i] = Math.Max(Math.Max(maxDP[i - 1] * nums[i], minDP[i - 1] * nums[i]), nums[i]);
                minDP[i] = Math.Min(Math.Min(maxDP[i - 1] * nums[i], minDP[i - 1] * nums[i]), nums[i]);

                max = Math.Max(max, maxDP[i]);
            }

            return max;
        }
    }
}
