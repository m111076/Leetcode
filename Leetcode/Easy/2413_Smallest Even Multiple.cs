using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2413_Smallest_Even_Multiple
    {
        public int SmallestEvenMultiple(int n)
        {
            //runtime 100%
            if (n == 0) return 0;

            if (n % 2 != 0) return n * 2;
            else return n;
        }
    }
}
