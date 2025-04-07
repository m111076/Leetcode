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
        //runtime 84%
        //DP經典題
        //Time complexity O(n*target)
        //Space complexity O(target)
        public bool CanPartition(int[] nums)
        {
            var sum = nums.Sum();
            var target = sum / 2;

            if ((sum & 1) != 0)
                return false;

            var length = nums.Length;
            var dp = new bool[target + 1];
            //空集合必定可以
            dp[0] = true;

            foreach (var num in nums)
            {
                for (int i = target; i >= num; i--)
                {
                    dp[i] = dp[i - num] || dp[i];
                }
            }

            return dp[target];
        }
    }
}
