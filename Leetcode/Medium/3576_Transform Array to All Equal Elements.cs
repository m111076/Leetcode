using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _3576_Transform_Array_to_All_Equal_Elements
    {
        //runtime 91%
        //time complexity O(n)
        //space complexity O(n)
        //要記得複製一份
        public static bool CanMakeEqual(int[] nums, int k)
        {
            var tmpNums = (int[])nums.Clone();
            return Check(nums, 1, k) || Check(tmpNums, -1, k);
        }

        public static bool Check(int[] nums, int target, int k)
        {
            var cnt = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != target)
                {
                    nums[i] *= -1;
                    nums[i + 1] *= -1;
                    cnt++;
                }
                if (cnt > k)
                    return false;
            }
            if (nums[nums.Length - 1] != target)
                return false;

            return true;
        }
    }
}
