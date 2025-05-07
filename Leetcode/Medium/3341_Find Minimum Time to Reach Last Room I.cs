using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3341_Find_Minimum_Time_to_Reach_Last_Room_I
    {
        public int MinTimeToReach(int[][] moveTime)
        {
            var dp = new int[moveTime.Length, moveTime[0].Length];
            moveTime[0][0] = 0;
            for (var i = 1; i < moveTime[0].Length; i++)
            {
                dp[0, i] = Math.Max(dp[0, i - 1], moveTime[0][i]) + 1;
            }
            for (var i = 1; i < moveTime.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], moveTime[i][0]) + 1;
            }

            for (var i = 1; i < moveTime.Length; i++)
            {
                for (var j = 1; j < moveTime[i].Length; j++)
                {
                    var tmpMin = Math.Min(dp[i - 1, j], dp[i, j - 1]);
                    dp[i, j] = Math.Max(tmpMin, moveTime[i][j]) + 1;
                }
            }

            return dp[moveTime.Length - 1, moveTime[0].Length - 1];
        }
    }
}
