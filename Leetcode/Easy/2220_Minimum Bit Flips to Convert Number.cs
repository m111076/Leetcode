using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2220_Minimum_Bit_Flips_to_Convert_Number
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        public int MinBitFlips(int start, int goal)
        {
            var target = start ^ goal;
            var result = 0;

            while (target > 0)
            {
                target &= target - 1;
                result++;
            }

            return result;
        }
    }
}
