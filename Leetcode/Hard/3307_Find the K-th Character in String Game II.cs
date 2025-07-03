using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3307_Find_the_K_th_Character_in_String_Game_II
    {
        //runtime 100%
        //time complexity O(logk)
        //space complexity O(1)
        public char KthCharacter(long k, int[] operations)
        {
            //k也可以轉為0-index，這樣判斷的地方就要變成k >= (1L << i)
            var cnt = 0L;
            var leftBit = BitOperations.Log2((ulong)k);//0-base

            for (var i = leftBit; i >= 0; i--)
            {
                if (k > (1L << i))
                {
                    k -= (1L << i);
                    cnt += operations[i];
                }
            }

            return (char)('a' + cnt % 26);
        }
    }
}
