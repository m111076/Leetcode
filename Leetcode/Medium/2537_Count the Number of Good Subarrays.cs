using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2537_Count_the_Number_of_Good_Subarrays
    {


        public long CountGood(int[] nums, int k)
        {
            //runtime 91%
            var left = 0;
            var right = 0;
            var result = 0L;
            var pairCnt = 0;
            var dic = new Dictionary<int, int>();

            while (right < nums.Length)
            {
                if (dic.TryGetValue(nums[right], out int pair))
                {
                    pairCnt += pair;
                    dic[nums[right]]++;
                }
                else
                {
                    dic.Add(nums[right], 1);
                }

                while (pairCnt >= k)
                {
                    pairCnt -= dic[nums[left]] - 1;
                    dic[nums[left]]--;
                    if (dic[nums[left]] == 0)
                        dic.Remove(nums[left]);
                    left++;
                }
                result += left;
                right++;
            }
            return result;


            //runtime 100%
            //time complexity: O(n)
            //space complexity: O(n)
            // The idea is to use a sliding window approach with a dictionary to count the occurrences of each number.
            //var result = 0L;
            //var map = new Dictionary<int, int>();
            //var left = 0;

            //for (var right = 0; right < nums.Length; right++)
            //{
            //    if (map.TryGetValue(nums[right], out var count))
            //    {
            //        k -= count;
            //        map[nums[right]]++;
            //    }
            //    else
            //    {
            //        map.Add(nums[right], 1);
            //    }

            //    while (k <= 0)
            //    {
            //        if (map.TryGetValue(nums[left], out var countLeft))
            //        {
            //            k += countLeft - 1;
            //            map[nums[left]]--;
            //            if (map[nums[left]] == 0)
            //                map.Remove(nums[left]);
            //        }
            //        left++;
            //    }

            //    result += left;
            //}

            //return result;
        }
    }
}
