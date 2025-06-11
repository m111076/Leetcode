using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0647_Palindromic_Substrings
    {
        //runtime 77%
        //time complexity O(n^2)
        //space complexity O(n^2)
        private bool[,] dp;
        private int Result = 0;

        public int CountSubstrings(string s)
        {
            dp = new bool[s.Length, s.Length];

            for (var i = s.Length - 1; i >= 0; i--)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1]))
                    {
                        dp[i, j] = true;
                        Result++;
                    }
                }
            }

            return Result;
        }

        //private void DFS(string s, int idx, int start)
        //{
        //    if (idx == s.Length)
        //    {
        //        return;
        //    }

        //    //不切
        //    if (idx < s.Length - 1)
        //        DFS(s, idx + 1, start);
        //    //切

        //    if (dp[start, idx])
        //    {
        //        Result++;
        //        DFS(s, idx + 1, idx + 1);
        //    }
        //}
    }
}
