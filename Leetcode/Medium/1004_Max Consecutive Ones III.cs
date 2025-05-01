using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1004_Max_Consecutive_Ones_III
    {
        //runtime 91%
        //time complexity O(n)
        public int LongestOnes(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var zeroCnt = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                    zeroCnt++;

                while (zeroCnt > k)
                {
                    if (nums[left++] == 0)
                        zeroCnt--;
                }

                result = Math.Max(result, right - left + 1);

                right++;
            }

            return result;
        }
    }
}
