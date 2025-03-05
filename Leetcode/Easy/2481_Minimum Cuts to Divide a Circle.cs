using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2481_Minimum_Cuts_to_Divide_a_Circle
    {
        public int NumberOfCuts(int n)
        {
            //runtime 100%
            //忘記1不用畫線
            if (n == 1)
                return 0;

            if (n % 2 != 0)
                return n;
            else
                return n / 2;
        }
    }
}
