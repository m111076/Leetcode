using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.WC._439
{
    public class Q2_Longest_Palindromic_Subsequence_After_at_Most_K_Operations
    {
        public static int LongestPalindromicSubsequence(string s, int k)
        {
            int n = s.Length;
            var dp = new int[n + 1, n + 1];
            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (s[i] == s[n - j])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return 0;
        }
    }
}
