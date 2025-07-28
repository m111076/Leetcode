using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3622_Check_Divisibility_by_Digit_Sum_and_Product
    {
        public bool CheckDivisibility(int n)
        {
            var digitSum = 0;
            var digitProduct = 1;
            var tmpN = n;

            while (n > 0)
            {
                var digit = n % 10;
                digitSum += digit;
                digitProduct *= digit;
                n /= 10;
            }

            return tmpN % (digitSum + digitProduct) == 0;
        }
    }
}
