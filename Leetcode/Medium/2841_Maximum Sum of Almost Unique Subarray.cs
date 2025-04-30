using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2841_Maximum_Sum_of_Almost_Unique_Subarray
    {
        //runtime 87%
        //time complexity O(n)
        //space complexity O(n)
        //滑動視窗
        public long MaxSum(IList<int> nums, int m, int k)
        {
            var dict = new Dictionary<int, int>();
            var sum = 0L;
            var result = 0L;

            for (var i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }

                if (i < k - 1)
                    continue;

                if (dict.Count >= m)
                {
                    result = Math.Max(result, sum);
                }

                sum -= nums[i - k + 1];
                dict[nums[i - k + 1]]--;
                if (dict[nums[i - k + 1]] == 0)
                {
                    dict.Remove(nums[i - k + 1]);
                }
            }

            return result;
        }
    }
}
