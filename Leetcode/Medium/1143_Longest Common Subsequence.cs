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
            //runtime 57%
            //time complexity O(n*m)
            //space complexity O(n*m)
            //當字元相同時取前面最長共同子序列+1，否則比較dp[i - 1, j], dp[i, j - 1]
            var dp = new int[text1.Length + 1, text2.Length + 1];

            for (var i = 1; i <= text1.Length; i++)
            {
                for (var j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[text1.Length, text2.Length];
        }
    }
}
