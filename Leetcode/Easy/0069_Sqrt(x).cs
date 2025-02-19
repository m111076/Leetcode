using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _69_Sqrt_x_
    {
        public static int MySqrt(int x)
        {
            if (x <= 1)
                return x;

            var left = 0;
            var right = x;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var square = (long)mid * mid;
                if (square == x)
                    return mid;
                else if (square < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return right;
        }
    }
}
