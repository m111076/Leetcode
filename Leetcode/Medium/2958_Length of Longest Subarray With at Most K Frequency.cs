using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2958_Length_of_Longest_Subarray_With_at_Most_K_Frequency
    {
        //runtime 72%
        //time complexity O(n)
        public int MaxSubarrayLength(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var dic = new Dictionary<int, int>();

            while (right < nums.Length)
            {
                if (!dic.ContainsKey(nums[right]))
                    dic.Add(nums[right], 0);
                dic[nums[right]]++;

                while (dic[nums[right]] > k)
                {
                    dic[nums[left]]--;
                    left++;
                }

                result = Math.Max(result, right - left + 1);

                right++;
            }

            return result;
        }
    }
}
