using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1493_Longest_Subarray_of_1_s_After_Deleting_One_Element
    {
        //runtime 61%
        //time complexity O(n)
        //space complexity O(1)
        public int LongestSubarray(int[] nums)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var zeroCnt = 0;
            var isZero = false;


            while (right < nums.Length)
            {
                if (nums[right] == 0 && zeroCnt != 0)
                {
                    isZero = true;
                    if (nums[left++] == 0)
                        zeroCnt--;
                }
                else
                {
                    if (nums[right] == 0)
                    {
                        isZero = true;
                        zeroCnt++;
                    }
                    result = Math.Max(result, right - left + 1 - zeroCnt);
                    right++;
                }
            }

            return isZero ? result : result - 1;
        }
    }
}
