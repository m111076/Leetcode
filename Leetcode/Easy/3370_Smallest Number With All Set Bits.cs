using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3370_Smallest_Number_With_All_Set_Bits
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        public int SmallestNumber(int n)
        {
            var result = 0;

            while (n > result)
            {
                result = (result << 1) + 1;
            }

            return result;
        }
    }
}
