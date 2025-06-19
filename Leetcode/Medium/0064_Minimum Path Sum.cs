using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0064_Minimum_Path_Sum
    {
        //runtiem 57%
        //time complexity O(m*n)
        //space complexity O(m*n)
        //DP
        public int MinPathSum(int[][] grid)
        {
            var dp = new int[grid.Length, grid[0].Length];
            dp[0, 0] = grid[0][0];

            for (var i = 1; i < grid.Length; i++)
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];

            for (var j = 1; j < grid[0].Length; j++)
                dp[0, j] = dp[0, j - 1] + grid[0][j];

            for (var i = 1; i < grid.Length; i++)
            {
                for (var j = 1; j < grid[0].Length; j++)
                {
                    dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                }
            }

            return dp[grid.Length - 1, grid[0].Length - 1];
        }
    }
}
