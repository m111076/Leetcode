using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1732_Find_the_Highest_Altitude
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int LargestAltitude(int[] gain)
        {
            var result = 0;
            var tmp = 0;

            foreach (var a in gain)
            {
                tmp += a;
                result = Math.Max(tmp, result);
            }

            return result;
        }
    }
}
