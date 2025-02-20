using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0191_Number_of_1_Bits
    {
        public int HammingWeight(int n)
        {
            var oneCnt = 0;

            while (n != 0)
            {
                //範例寫法
                //oneCnt += n & 1;
                //n >>= 1;

                //runtime 100%
                n &= n - 1;
                oneCnt++;
            }

            return oneCnt;
        }
    }
}
