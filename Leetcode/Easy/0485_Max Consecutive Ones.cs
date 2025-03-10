using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0485_Max_Consecutive_Ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var result = 0;
            var tmp = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    tmp++;
                else
                {
                    result = Math.Max(result, tmp);
                    tmp = 0;
                }
                result = Math.Max(result, tmp);
            }
            return result;
        }
    }
}
