using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0583_Delete_Operation_for_Two_Strings
    {
        public int MinDistance(string word1, string word2)
        {
            //runtime 51%
            //LCS求最大
            var s1 = word1.Length;
            var s2 = word2.Length;
            var dp = new int[s1 + 1, s2 + 1];

            for (var i = 1; i <= s1; i++)
            {
                for (var j = 1; j <= s2; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return s1 + s2 - dp[s1, s2] * 2;

        }
    }
}
