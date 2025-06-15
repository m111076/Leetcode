using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0136_Single_Number
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //XOR運算
        public int SingleNumber(int[] nums)
        {
            var result = 0;

            foreach (var item in nums)
            {
                result ^= item;
            }

            return result;
        }
    }
}
