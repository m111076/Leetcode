using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0342_Power_of_Four
    {
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0) return false;

            while (n > 1)
            {
                if (n % 4 != 0) return false;
                n /= 4;
            }
            return true;
        }
    }
}
