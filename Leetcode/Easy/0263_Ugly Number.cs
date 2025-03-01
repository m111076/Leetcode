using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0263_Ugly_Number
    {
        public bool IsUgly(int n)
        {
            //runtime 100%
            //若因數只有2、3、5，最後剩下的數字為1
            if (n == 0) return false;

            while (n % 2 == 0)
                n /= 2;
            while (n % 3 == 0)
                n /= 3;
            while (n % 5 == 0)
                n /= 5;
            return n == 1;
        }
    }
}
