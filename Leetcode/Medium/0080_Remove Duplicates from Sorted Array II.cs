using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0080_Remove_Duplicates_from_Sorted_Array_II
    {
        public static int RemoveDuplicates(int[] nums)
        {
            //runtime 70%
            //time complexity O(n)
            //space complexity O(1)
            // 這題的重點在於要保留最多兩個相同的數字
            var cnt = 0;
            var amount = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[cnt] != nums[i])
                {
                    nums[++cnt] = nums[i];
                    amount = 1;
                }
                else if (amount == 1)
                {
                    nums[++cnt] = nums[i];
                    amount = 0;
                }
            }

            return cnt + 1;
        }
    }
}
