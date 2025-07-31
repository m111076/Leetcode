using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0868_Binary_Gap
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        public int BinaryGap(int n)
        {
            var high = BitOperations.Log2((uint)n);
            var result = 0;
            var preIdx = -1;

            for (var i = 0; i <= high; i++)
            {
                if ((n & 1) == 1)
                {
                    if (preIdx != -1)
                    {
                        result = Math.Max(result, i - preIdx);
                    }
                    preIdx = i;
                }
                n >>= 1;
            }

            return result;
        }
    }
}
