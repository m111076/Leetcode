using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2460_Apply_Operations_to_an_Array
    {
        public int[] ApplyOperations(int[] nums)
        {
            var result = new int[nums.Length];
            var length = nums.Length;
            var idx = 0;

            for (var i = 0; i < length - 1; i++)
            {
                if (nums[i] != 0)
                {
                    if (nums[i] == nums[i + 1])
                    {
                            result[idx++] = nums[i] * 2;
                            nums[i + 1] = 0;
                    }
                    else
                    {
                            result[idx++] = nums[i];
                    }
                }

                if (i == length - 2 && nums[length - 1] != 0)
                    result[idx++] = nums[length - 1];
            }

            return result;
        }
    }
}
