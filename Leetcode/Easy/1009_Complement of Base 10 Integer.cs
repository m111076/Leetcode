using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1009_Complement_of_Base_10_Integer
    {
        //runtime 100%
        //time complexity O(1)
        //space complexity O(1)
        public int BitwiseComplement(int n)
        {
            var maskLength = BitOperations.Log2((uint)n) + 1;
            var mask = (1 << maskLength) - 1;

            return n ^ mask;
        }
    }
}
