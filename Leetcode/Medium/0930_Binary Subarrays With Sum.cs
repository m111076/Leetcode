using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0930_Binary_Subarrays_With_Sum
    {
        //runtime 62%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗 搭配at least
        public static int NumSubarraysWithSum(int[] nums, int goal)
        {
            return Check(nums, goal) - Check(nums, goal + 1);
        }

        private static int Check(int[] iNums, int iGoal)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var cnt = 0;

            while (right < iNums.Length)
            {
                if (iNums[right] == 1)
                    cnt++;

                while (left <= right && cnt >= iGoal)
                {
                    if (iNums[left++] == 1)
                        cnt--;
                }
                result += left;
                right++;
            }

            return result;
        }
    }
}
