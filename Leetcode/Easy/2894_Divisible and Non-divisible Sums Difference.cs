using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2894_Divisible_and_Non_divisible_Sums_Difference
    {
        //runtime 91%
        //time complexity O(n)
        //space complexity O(1)
        public int DifferenceOfSums(int n, int m)
        {
            var result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0)
                    result += i;
                else
                    result -= i;
            }

            return result;
        }
    }
}
