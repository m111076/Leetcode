using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0190_Reverse_Bits
    {
        public static uint reverseBits(uint n)
        {
            //範例87%
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result += (n & 1);
                n >>= 1;
            }
            return result;

            //runtime 41%
            //var result = uint.MinValue;
            //for (var i = 0; i < 32; i++)
            //{
            //    var target = n & 1;
            //    n >>= 1;
            //    result |= target << (32 - 1 - i);
            //}
            //return result;

        }
    }
}
