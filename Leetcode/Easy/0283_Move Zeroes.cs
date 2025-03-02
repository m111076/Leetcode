using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0283_Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {

            var length = nums.Length;
            var idx = 0;

            for (var i = 0; i < length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[idx] = nums[i];
                    if (idx++ != i)
                        nums[i] = 0;
                }
            }
        }
    }
}
