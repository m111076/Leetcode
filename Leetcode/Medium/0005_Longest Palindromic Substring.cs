using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0005_Longest_Palindromic_Substring
    {
        //runtime 45%
        //time complexity O(n*n)
        //space complexity O(n*n)
        //DP
        public string LongestPalindrome(string s)
        {
            var dp = new bool[s.Length, s.Length];

            var maxLength = 1;
            var start = 0;

            for (var i = s.Length - 1; i >= 0; i--)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1]))
                    {
                        dp[i, j] = true;
                        if (j - i + 1 > maxLength)
                        {
                            maxLength = j - i + 1;
                            start = i;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}
