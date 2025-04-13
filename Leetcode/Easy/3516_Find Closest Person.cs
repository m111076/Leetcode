using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //
    //time complexity: O(1)
    //space complexity: O(1)
    internal class _3516_Find_Closest_Person
    {
        public int FindClosest(int x, int y, int z)
        {
            var v1 = Math.Abs(x - z);
            var v2 = Math.Abs(y - z);

            if (v1 == v2)
            {
                return 0;
            }
            else if (v1 > v2)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
