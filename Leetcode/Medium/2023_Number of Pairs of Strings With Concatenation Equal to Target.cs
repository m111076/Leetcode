using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2023_Number_of_Pairs_of_Strings_With_Concatenation_Equal_to_Target
    {
        //runtime 58%
        //time complexity O(n^2)
        //space complexity O(1)
        public int NumOfPairs(string[] nums, string target)
        {
            var result = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result++;
                    }
                    if (nums[j] + nums[i] == target)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
