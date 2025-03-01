using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    public class _1092_Shortest_Common_Supersequence
    {
        public static string ShortestCommonSupersequence(string str1, string str2)
        {
            var s1Length = str1.Length;
            var s2Length = str2.Length;
            var dp = new int[s1Length + 1, s2Length + 1];

            for (var i = 1; i <= s1Length; i++)
            {
                for (var j = 1; j <= s2Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            var result = string.Empty;

            while (s1Length > 0 && s2Length > 0)
            {
                if (str1[s1Length - 1] == str2[s2Length - 1])
                {
                    result += str1[s1Length - 1];
                    s1Length--;
                    s2Length--;
                }
                else if (dp[s1Length - 1, s2Length] > dp[s1Length, s2Length - 1])
                {
                    result += str1[s1Length - 1];
                    s1Length--;
                }
                else
                {
                    result += str2[s2Length - 1];
                    s2Length--;
                }
            }

            while (s1Length > 0)
            {
                result += str1[s1Length - 1];
                s1Length--;
            }

            while (s2Length > 0)
            {
                result += str2[s2Length - 1];
                s2Length--;
            }

            return new string(result.Reverse().ToArray());
        }
    }
}
