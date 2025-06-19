using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0005_Longest_Palindromic_Substring
    {

        public string LongestPalindrome(string s)
        {
            //runtime 96%
            //time complexity O(n)
            //space complexity O(n)
            //Manacher’s Algorithm
            var str = "^#" + string.Join("#", s.ToCharArray()) + "#$";
            var pR = new int[str.Length];
            var center = 0;
            var rightLimit = 0;

            for (var i = 1; i < str.Length - 1; i++)
            {
                if (i < rightLimit)
                {
                    pR[i] = Math.Min(rightLimit - i, pR[2 * center - i]);
                }

                while (str[i + 1 + pR[i]] == str[i - 1 - pR[i]])
                    pR[i]++;
                
                if (i + pR[i] > rightLimit)
                {
                    center = i;
                    rightLimit = i + pR[i];
                }
            }

            var maxLength = 0;
            var centerIdx = 0;

            for (var i = 1; i < str.Length - 1; i++)
            {
                if (pR[i] > maxLength)
                {
                    maxLength = pR[i];
                    centerIdx = i;
                }
            }

            var startIdx = (centerIdx - maxLength) / 2;
            return s.Substring(startIdx, maxLength);

            //runtime 45%
            //time complexity O(n*n)
            //space complexity O(n*n)
            //DP
            //var dp = new bool[s.Length, s.Length];

            //var maxLength = 1;
            //var start = 0;

            //for (var i = s.Length - 1; i >= 0; i--)
            //{
            //    for (var j = i; j < s.Length; j++)
            //    {
            //        if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1]))
            //        {
            //            dp[i, j] = true;
            //            if (j - i + 1 > maxLength)
            //            {
            //                maxLength = j - i + 1;
            //                start = i;
            //            }
            //        }
            //    }
            //}

            //return s.Substring(start, maxLength);
        }
    }
}
