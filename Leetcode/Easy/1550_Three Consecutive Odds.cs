using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1550_Three_Consecutive_Odds
    {
        //runtime 100%
        //time complexity O(n)
        //(a & 1) != 0
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var max = 3;

            foreach (var a in arr)
            {
                if ((a & 1) != 0)
                    max--;
                else
                    max = 3;

                if(max == 0)
                    return true;
            }

            return false;
        }
    }
}
