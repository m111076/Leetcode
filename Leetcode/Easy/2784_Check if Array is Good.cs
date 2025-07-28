using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2784_Check_if_Array_is_Good
    {
        public bool IsGood(int[] nums)
        {
            //runtime 57%
            //time complexity O(n log n)
            //space complexity O(1)
            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != i + 1)
                    return false;
            }

            return nums[^1] == nums.Length - 1;

            //數字有可能被設計過
            //if (nums.Length == 1)
            //    return false;
            //if (nums.Length == 2)
            //    return nums[0] == 1 && nums[1] == 1;
            //var length = nums.Length;
            //var target = (1 + length - 1) * (length - 1) / 2 + length - 1;
            //var sum = nums.Sum();

            //return target == sum;
        }
    }
}
