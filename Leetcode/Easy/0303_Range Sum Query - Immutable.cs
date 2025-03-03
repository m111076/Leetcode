using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0303_Range_Sum_Query___Immutable
    {
        public class NumArray
        {
            public int[] ints;
            public NumArray(int[] nums)
            {
                var length = nums.Length;
                ints = new int[length + 1];

                for (var i = 0; i < length; i++)
                {
                    ints[i + 1] = ints[i] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                return ints[right+1] - ints[left+1];
            }
        }
    }
}
