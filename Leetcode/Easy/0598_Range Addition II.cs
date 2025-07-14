using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0598_Range_Addition_II
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MaxCount(int m, int n, int[][] ops)
        {
            var minRow = m;
            var minCol = n;

            foreach (var op in ops)
            {
                minRow = Math.Min(minRow, op[0]);
                minCol = Math.Min(minCol, op[1]);
            }

            return minRow * minCol;
        }
    }
}
