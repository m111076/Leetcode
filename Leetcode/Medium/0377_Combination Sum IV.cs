using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0377_Combination_Sum_IV
    {
        //runtime 79%
        //time complexity O(n*t)
        //space complexity O(t)
        //順序有差:容量在外，物品在內
        //順序沒差，物品在外，容量在內
        public int CombinationSum4(int[] nums, int target)
        {
            Array.Sort(nums);
            var dp = new int[target + 1];
            dp[0] = 1;

            for (var i = 1; i <= target; i++)
            {
                foreach (var num in nums)
                {
                    if (i - num < 0)
                        break;
                    dp[i] += dp[i - num];
                }
            }

            return dp[target];
        }
    }
}
