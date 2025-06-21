using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0416_Partition_Equal_Subset_Sum
    {
        //runtime 90%
        //time complexity O(n*m)
        //space complexity O(m)
        public bool CanPartition(int[] nums)
        {
            var sum = nums.Sum();

            if (sum % 2 == 1)
                return false;

            var target = sum / 2;
            var dp = new bool[target + 1];
            dp[0] = true;

            foreach (var num in nums)
            {
                for (int j = target; j >= num; j--)
                {
                    dp[j] |= dp[j - num];
                }
            }

            return dp[^1];
        }
    }
}
