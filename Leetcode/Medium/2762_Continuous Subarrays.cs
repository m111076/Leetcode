using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2762_Continuous_Subarrays
    {
        //runtime 63%
        //time complexity O(nlogn)
        //space complexity O(n)
        //滑動視窗
        //SortedDictionary使用方法
        public long ContinuousSubarrays(int[] nums)
        {
            var left = 0;
            var right = 0;
            var result = 0L;
            var sDic = new SortedDictionary<int, int>();

            while (right < nums.Length)
            {
                if (!sDic.TryAdd(nums[right], 1))
                    sDic[nums[right]]++;

                while (sDic.Count > 0 && sDic.Last().Key - sDic.First().Key > 2)
                {
                    sDic[nums[left]]--;

                    if (sDic[nums[left]] == 0)
                        sDic.Remove(nums[left]);
                    left++;
                }

                result += right - left + 1;
                right++;
            }

            return result;
        }
    }
}
