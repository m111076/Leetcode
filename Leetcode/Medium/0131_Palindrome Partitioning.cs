using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0131_Palindrome_Partitioning
    {
        //runtime 99%
        //time complexity O(2^n * n)
        //space complexity O(n)
        //用DFS+DP
        //runtime 100%
        //time complexity O(n^2 +n*n)
        private List<IList<string>> Result = new List<IList<string>>();
        private bool[,] dp;

        public IList<IList<string>> Partition(string s)
        {
            dp = new bool[s.Length, s.Length];

            for (var i = s.Length - 1; i >= 0; i--)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1]))
                        dp[i, j] = true;
                }
            }

            DFS(s, 0, 0, new List<string>());

            return Result;
        }

        private void DFS(string s, int idx, int start, List<string> tmpResults)
        {
            if (idx == s.Length)
            {
                Result.Add(new List<string>(tmpResults));
                return;
            }

            //不切
            if (idx < s.Length - 1)
                DFS(s, idx + 1, start, tmpResults);
            //切
            if (dp[start, idx])
            {
                tmpResults.Add(s.Substring(start, idx - start + 1));
                DFS(s, idx + 1, idx + 1, tmpResults);
                tmpResults.RemoveAt(tmpResults.Count - 1);
            }

        }
        //O(n)
        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                    return false;
            }
            return true;
        }
    }
}
