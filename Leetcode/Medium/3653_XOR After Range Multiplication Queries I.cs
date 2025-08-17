using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3653_XOR_After_Range_Multiplication_Queries_I
    {
        //runtime 52%
        //time complexity O(n*q)
        //space complexity O(1)
        public int XorAfterQueries(int[] nums, int[][] queries)
        {
            foreach (var query in queries)
            {
                var idx = query[0];
                while (idx < nums.Length && idx <= query[1])
                {
                    nums[idx] = (int)((1L * nums[idx] * query[3]) % 1000000007);
                    idx += query[2];
                }
            }

            var result = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}
