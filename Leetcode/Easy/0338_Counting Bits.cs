using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0338_Counting_Bits
    {
        public int[] CountBits(int n)
        {
            //runtime 100%
            //位元運算，i中1的數量等於i的bit右移一位後的1的數量+i本身的第一位
            var result = new int[n + 1];

            for (var i = 1; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }

            return result;
        }
    }
}
