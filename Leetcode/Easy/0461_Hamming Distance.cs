using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0461_Hamming_Distance
    {
        public int HammingDistance(int x, int y)
        {
            //runtime 100%
            //先用XOR算出相異的部分
            //hammingweight
            var target = x ^ y;
            var cnt = 0;

            while (target != 0)
            {
                cnt++;
                target &= target - 1;
            }

            return cnt;
        }
    }
}
