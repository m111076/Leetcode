using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2176_Count_Equal_and_Divisible_Pairs_in_an_Array
    {
        //runtime 100%
        //time complexity: O(n^2)
        //space complexity: O(1)
        //暴力解
        public int CountPairs(int[] nums, int k)
        {
            var result = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && (i * j) % k == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
