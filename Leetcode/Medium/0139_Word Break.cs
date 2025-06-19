using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0139_Word_Break
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            //runtime 97%
            //time complexity O(n*m)
            //space complexity O(n)
            var dp = new bool[s.Length + 1];
            var maxLength = wordDict.Max(w => w.Length);
            dp[0] = true;

            for (var i = 1; i <= s.Length; i++)
            {
                for (var j = i - 1; j >= Math.Max(i - maxLength - 1, 0); j--)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[^1];
        }
    }
}
