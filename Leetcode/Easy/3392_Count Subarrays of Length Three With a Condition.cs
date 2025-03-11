using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3392_Count_Subarrays_of_Length_Three_With_a_Condition
    {
        public int CountSubarrays(int[] nums)
        {
            //runtime 100%
            var limit = nums.Length - 1;
            var result = 0;

            for (var i = 1; i < limit; i++)
            {
                result += 2 * (nums[i - 1] + nums[i + 1]) == nums[i] ? 1 : 0;
            }
            return result;
        }
    }
}
