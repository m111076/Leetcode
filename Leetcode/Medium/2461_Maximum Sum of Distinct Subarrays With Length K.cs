using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _2461_Maximum_Sum_of_Distinct_Subarrays_With_Length_K
    {
        public static long MaximumSubarraySum(int[] nums, int k)
        {
            //改用HashSet+Sliding Window
            //runtime 45%
            //time complexity O(n)
            //space complexity O(n)
            var result = 0L;
            var tmp = new HashSet<int>();
            var tmpResult = 0L;
            var left = 0;

            for (var right = 0; right < nums.Length; right++)
            {

                if (!tmp.Contains(nums[right]))
                {
                    tmpResult += nums[right];
                    tmp.Add(nums[right]);

                    if (right - left + 1 == k)
                    {
                        result = Math.Max(result, tmpResult);
                        tmpResult -= nums[left];
                        tmp.Remove(nums[left]);
                        left++;
                    }
                }
                else
                {
                    while (nums[right] != nums[left])
                    {
                        tmp.Remove(nums[left]);
                        tmpResult -= nums[left];
                        left++;
                    }
                    left++;
                }
            }

            return result;

            //TLE
            //var result = 0L;
            //var tmp = new Dictionary<int, int>();
            //var tmpQ = new Queue<long>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    tmpQ.Enqueue(nums[i]);

            //    if (tmp.ContainsKey(nums[i]))
            //    {
            //        tmp[nums[i]]++;
            //    }
            //    else
            //    {
            //        tmp[nums[i]] = 1;
            //    }

            //    if (tmpQ.Count > k)
            //    {
            //        var t = (int)tmpQ.Dequeue();
            //        tmp[t]--;
            //        if (tmp[t] == 0)
            //        {
            //            tmp.Remove(t);
            //        }
            //    }

            //    if (tmp.Count == k)
            //    {
            //        result = Math.Max(result, tmpQ.Sum());
            //    }
            //}

            //return result;
        }
    }
}
