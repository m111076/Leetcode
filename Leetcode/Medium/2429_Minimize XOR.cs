using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2429_Minimize_XOR
    {
        //runtime 100%
        //time complexity O(1)
        //space complexity O(1)
        public int MinimizeXor(int num1, int num2)
        {
            var result = num1;
            var n2 = hamming(num2);
            var n1 = hamming(num1);
            var cnt = n2 - n1;

            if (cnt >= 0)
            {
                while (cnt > 0)
                {
                    result |= result + 1;
                    cnt--;
                }
            }
            else
            {
                while (cnt < 0)
                {
                    result &= result - 1;
                    cnt++;
                }
            }
            return result;
        }

        private int hamming(int num)
        {
            var result = 0;

            while (num > 0)
            {
                num &= num - 1;
                //這也可以
                //num >> 1;
                result++;
            }
            return result;
        }
    }
}
