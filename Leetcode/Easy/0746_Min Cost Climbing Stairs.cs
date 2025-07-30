using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0746_Min_Cost_Climbing_Stairs
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 2)
                return Math.Min(cost[0], cost[1]);

            for (var i = 2; i < cost.Length; i++)
            {
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            }

            return Math.Min(cost[^1], cost[^2]);
        }
    }
}
