using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 100%
    //time complexity O(logm*n)
    //idx要記得轉換成秒數
    internal static class _3048_Earliest_Second_to_Mark_Indices_I
    {
        public static int EarliestSecondToMarkIndices(int[] nums, int[] changeIndices)
        {
            if (nums.Length > changeIndices.Length)
                return -1;

            var left = nums.Length - 1;
            var right = changeIndices.Length;
            //O(logn)
            while (left < right)
            {
                var mid = left + (right - left) / 2;    

                if (Check(nums, changeIndices, mid))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left == changeIndices.Length ? -1 : left + 1;
        }

        private static bool Check(int[] nums, int[] changeIndices, int time)
        {
            var mark = Enumerable.Repeat(-1, nums.Length).ToArray();
            var available = 0;

            //O(n)
            for (int i = 0; i <= time; i++)
            {
                mark[changeIndices[i] - 1] = i;
            }

            //O(n)
            foreach (var m in mark)
            {
                if (m < 0)
                    return false;
            }

            //O(n)
            for (int i = 0; i <= time; i++)
            {
                var idx = changeIndices[i] - 1;

                if (i == mark[idx])
                {
                    if (nums[idx] > available)
                        return false;
                    available -= nums[idx];
                }
                else
                {
                    available++;
                }
            }

            return true;
        }
    }
}
