using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1143_Longest_Common_Subsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            //runtime 58%
            var s1 = text1.Length;
            var s2 = text2.Length;
            var dp = new int[s1 + 1, s2 + 1];

            for (var i = 1; i <= s1; i++)
            {
                for (var j = 1; j <= s2; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[s1, s2];
        }
    }
}
