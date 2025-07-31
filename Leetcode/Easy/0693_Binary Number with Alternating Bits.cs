using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0693_Binary_Number_with_Alternating_Bits
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        public bool HasAlternatingBits(int n)
        {
            var highIdx = BitOperations.Log2((uint)n);
            var preBit = 0;

            for (var i = highIdx; i >= 0; i--)
            {
                if (((n >> i) & 1) == preBit)
                    return false;
                preBit ^= 1;
            }

            return true;
        }
    }
}
