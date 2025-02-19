using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var cnt = 0;
            var temp = x;
            while (temp > 0)
            {
                temp /= 10;
                cnt++;
            }
            var hCnt = cnt / 2;
            for (var i = 0; i < hCnt; i++)
            {
                var L = x / (int)Math.Pow(10, cnt - 1 - i) % 10;
                var R = x % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
                if (L != R)
                    return false;
            }
            return true;
        }
    }
}
