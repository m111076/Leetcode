using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2140_Solving_Questions_With_Brainpower
    {
        public long MostPoints(int[][] questions)
        {
            var length = questions.Length;
            var dp = new long[length + 1];
            var max = 0L;

            for (var i = 1; i < length + 1; i++)
            {
                var skipIdx = questions[i - 1][1];
                long pt = questions[i - 1][0];

                if (i - skipIdx >= 0)
                    pt += dp[i - skipIdx];

                dp[i] = Math.Max(pt, dp[i - 1]);
            }

            return max;

        }
    }
}
