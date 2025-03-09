using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0463_Island_Perimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            //runtime 76%
            //單純判斷周圍有沒有地
            var cnt = 0;
            var row = grid.Length;
            var col = grid[0].Length;

            for (var r = 0; r < row; r++)
            {
                for (var c = 0; c < col; c++)
                {
                    var side = 0;
                    if (grid[r][c] == 1)
                    {
                        if (c == 0 || grid[r][c - 1] == 0)
                            side++;
                        if (r == 0 || grid[r - 1][c] == 0)
                            side++;
                        if (c == col - 1 || grid[r][c + 1] == 0)
                            side++;
                        if (r == row - 1 || grid[r + 1][c] == 0)
                            side++;
                        cnt += side;
                    }

                }
            }
            return cnt;
        }
    }
}
