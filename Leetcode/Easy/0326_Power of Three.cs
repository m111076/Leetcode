using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0326_Power_of_Three
    {
        public static bool IsPowerOfThree(int n)
        {
            //runtime 100%
            if (n <= 0) return false;

            while (n > 1)
            {
                if (n % 3 != 0) return false;
                n /= 3;
            }

            return true;
        }
    }
}
