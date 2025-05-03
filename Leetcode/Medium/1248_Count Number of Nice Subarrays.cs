using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1248_Count_Number_of_Nice_Subarrays
    {
        //runtime 62%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗 atmost
        public int NumberOfSubarrays(int[] nums, int k)
        {
            return CheckOdd(nums, k) - CheckOdd(nums, k - 1);
        }

        private int CheckOdd(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var cnt = 0;

            while (right < nums.Length)
            {
                if ((nums[right] & 1) != 0)
                    cnt++;

                while (cnt > k)
                {
                    if ((nums[left++] & 1) != 0)
                        cnt--;
                }

                result += right - left + 1;
                right++;
            }

            return result;
        }
    }
}
