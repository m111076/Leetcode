using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _26_Remove_Duplicates_from_Sorted_Array
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var cnt = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[cnt])
                    nums[++cnt] = nums[i];
            }

            return cnt + 1;
        }
    }
}
