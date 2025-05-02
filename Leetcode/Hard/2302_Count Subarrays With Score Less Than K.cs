using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _2302_Count_Subarrays_With_Score_Less_Than_K
    {
        public long CountSubarrays(int[] nums, long k)
        {
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            //sliding window
            var left = 0;
            var right = 0;
            var result = 0L;
            var sum = 0L;

            while (right < nums.Length)
            {
                sum += nums[right];

                while (sum * (right - left + 1) >= k)
                {
                    sum -= nums[left++];
                }

                result += right - left + 1;
                right++;
            }

            return result;

            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            //sliding window
            //var result = 0L;
            //var right = 0;
            //var left = 0;
            //var tmpSum = 0L;

            //for (; right < nums.Length; right++)
            //{
            //    tmpSum += nums[right];

            //    //當當下的nums[left]超過K時，會進下一趟，right+1=left，tmpSum必為0，result那邊必為+0，所以不必單獨考慮nums[left]超過K的情形
            //    while (tmpSum * (right - left + 1) >= k)
            //    {
            //        tmpSum -= nums[left++];
            //    }

            //    result += right - left + 1;
            //}

            //return result;
        }
    }
}
