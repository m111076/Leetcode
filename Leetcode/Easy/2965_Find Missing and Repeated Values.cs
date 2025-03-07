using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2965_Find_Missing_and_Repeated_Values
    {
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            //runtime 87%
            var length = grid.Length;
            var numAmount = length * length;
            var numsCnt = new int[numAmount + 1];

            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    numsCnt[grid[i][j]]++;
                }
            }

            var miss = -1;
            var repeat = -1;

            for (var i = 1; i <= numAmount; i++)
            {
                if (numsCnt[i] == 0)
                    miss = i;
                else if (numsCnt[i] == 2)
                    repeat = i;
            }

            return new int[] { repeat, miss };

        }
    }
}
