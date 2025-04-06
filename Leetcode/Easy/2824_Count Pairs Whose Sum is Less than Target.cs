using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _2824_Count_Pairs_Whose_Sum_is_Less_than_Target
    {
        //runtime 74%
        //Time complexity O(n^2)
        //Space complexity O(1)
        public static int CountPairs(IList<int> nums, int target)
        {
            var n = nums.Count();
            var  result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] < target)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
