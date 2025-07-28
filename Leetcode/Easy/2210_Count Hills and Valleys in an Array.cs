using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2210_Count_Hills_and_Valleys_in_an_Array
    {
        public int CountHillValley(int[] nums)
        {
            var result = 0;
            var isIncrease = false;
            var idx = 1;

            while (idx < nums.Length && nums[idx - 1] == nums[idx])
            {
                idx++;
            }

            if(idx == nums.Length)
            {
                return result;
            }

            isIncrease = nums[idx] > nums[idx - 1];

            for (int i = idx + 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    continue;
                }
                if (isIncrease)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        result++;
                        isIncrease = false;
                    }
                }
                else
                {
                    if (nums[i] > nums[i - 1])
                    {
                        result++;
                        isIncrease = true;
                    }
                }
            }

            return result;
        }
    }
}
