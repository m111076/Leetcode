using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3226_Number_of_Bit_Changes_to_Make_Two_Integers_Equal
    {
        //runtime 100%
        //time complexity O(logn)
        //space complexity O(1)
        public int MinChanges(int n, int k)
        {
            var tmp = n ^ k;
            if ((n | tmp) > n)
                return -1;

            var result = 0;
            while (tmp > 0)
            {
                tmp &= tmp - 1;
                result++;
            }

            return result;
        }
    }
}
