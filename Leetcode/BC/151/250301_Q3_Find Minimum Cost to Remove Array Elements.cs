using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BC
{
    public class _250301_Q3_Find_Minimum_Cost_to_Remove_Array_Elements
    {
        private Dictionary<string, int> memo = new Dictionary<string, int>();

        public int MinCost(int[] nums)
        {
            List<int> list = new List<int>(nums);
            return Helper(list);
        }

        private int Helper(List<int> nums)
        {
            if (nums.Count <= 2) return nums.Count == 0 ? 0 : nums.Max();

            string key = string.Join(",", nums);
            if (memo.TryGetValue(key, out int cached)) return cached;

            int minCost = int.MaxValue;

            for (int i = 0; i < Math.Min(3, nums.Count); i++)
            {
                for (int j = i + 1; j < Math.Min(3, nums.Count); j++)
                {
                    List<int> newNums = new List<int>(nums);
                    int cost = Math.Max(newNums[i], newNums[j]);

                    newNums.RemoveAt(j);
                    newNums.RemoveAt(i);

                    minCost = Math.Min(minCost, cost + Helper(newNums));
                }
            }

            memo[key] = minCost;
            return minCost;
        }
    }
}
