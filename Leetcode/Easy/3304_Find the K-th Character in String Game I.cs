using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3304_Find_the_K_th_Character_in_String_Game_I
    {
        //runtime 100%
        //因為題目的範圍，所以不需要%26
        public char KthCharacter(int k)
        {
            //手刻hammingweight
            k--;
            var oneCnt = 0;

            while (k > 0)
            {
                k &= (k - 1);
                oneCnt++;
            }

            return (char)('a' + oneCnt);

            //runtime 100%
            return (char)('a' + BitOperations.PopCount((uint)(k - 1)));
        }
    }
}
