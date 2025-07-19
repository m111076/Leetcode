using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1351_Count_Negative_Numbers_in_a_Sorted_Matrix
    {
        //runtime 100%
        //time complexity O(n*m)
        //space complexity O(1)
        public int CountNegatives(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                if (grid[i][0] < 0)
                {
                    result += grid[i].Length;
                    continue;
                }
                else
                {
                    for (var j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] < 0)
                        {
                            result += grid[i].Length - j;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
