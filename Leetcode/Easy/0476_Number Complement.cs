using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0476_Number_Complement
    {
        public int FindComplement(int num)
        {
            //runtime 100%
            //先將作出一個mask出來 ex 5=00000101 =>做一個 mask = 11111000
            //接著 ~mask = 00000111 接著將~5 => 11111010
            //兩者&後可以求得00000010
            //time complexity O(logn)
            var mask = ~0;
            while ((mask & num) != 0)
            {
                mask <<= 1;
            }

            return ~mask & ~num;

            //time complexity O(1)
            //sapce compelxity O(1)
            var highbit = BitOperations.Log2((uint)num);
            var mask2 = (1 << (highbit + 1)) - 1;

            return num ^ mask2;
        }
    }
}
