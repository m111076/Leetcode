using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2395_Find_Subarrays_With_Equal_Sum
    {
        //runtime 67%
        //time complexity O(n)
        //space complexity O(n)
        public bool FindSubarrays(int[] nums)
        {
            var set = new HashSet<int>();

            for (var i = 1; i < nums.Length; i++)
            {
                if (set.Contains(nums[i] + nums[i - 1]))
                {
                    return true;
                }
                set.Add(nums[i] + nums[i - 1]);
            }

            return false;
        }
    }
}
