using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0200_Number_of_Islands
    {
        //runtime 74%
        //time complexity O(m*n)
        //space complexity O(m*n)
        public int NumIslands(char[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        result++;
                    }
                }
            }

            return result;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1')
                return;

            grid[i][j] = '0';

            DFS(grid, i, j - 1);
            DFS(grid, i - 1, j);
            DFS(grid, i + 1, j);
            DFS(grid, i, j + 1);
        }
    }
}
