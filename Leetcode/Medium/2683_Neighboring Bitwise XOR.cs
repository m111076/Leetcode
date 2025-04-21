using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2683_Neighboring_Bitwise_XOR
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var xor = 0;

            foreach (var num in derived)
            {
                xor ^= num;
            }

            return xor == 0;

            //runtime 13%
            //time complexity O(n)
            //space complexity O(1)
            //觀察
            var zeroCnt = derived.Count(x => x == 1);
            return (zeroCnt & 1) == 0;
        }
    }
}
