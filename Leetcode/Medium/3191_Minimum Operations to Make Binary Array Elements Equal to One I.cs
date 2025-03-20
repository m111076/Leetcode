using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3191_Minimum_Operations_to_Make_Binary_Array_Elements_Equal_to_One_I
    {
        //runtime 85%
        //貪婪演算 XOR
        public int MinOperations(int[] nums)
        {
            var length = nums.Length;
            var flipCnt = 0;

            for (var i = 0; i < length - 2; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] ^= 1;
                    nums[i + 1] ^= 1;
                    nums[i + 2] ^= 1;
                    flipCnt++;
                }
            }

            return nums[length - 1] == 1 && nums[length - 2] == 1 ? flipCnt : -1;
        }
    }
}
