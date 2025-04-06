using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0368_Largest_Divisible_Subset
    {
        //runtime 87%
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            var length = nums.Length;
            var dp = new int[length];
            var prev = new int[length];
            var result = new List<int>();
            var maxLength = 0;
            var maxIdx = -1;

            for (int i = 0; i < length; i++)
            {
                dp[i] = 1;
                prev[i] = -1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }

                if (dp[i] > maxLength)
                {
                    maxLength = dp[i];
                    maxIdx = i;
                }
            }

            while (maxIdx != -1)
            {
                result.Add(nums[maxIdx]);
                maxIdx = prev[maxIdx];
            }

            result.Reverse();
            return result;
        }
    }
}
