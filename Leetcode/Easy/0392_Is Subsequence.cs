using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0392_Is_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            //runtime 100%
            //2pointer
            //s=""要記得
            if (s.Length == 0) return true;
            var sIdx = 0;
            var tIdx = 0;

            while (tIdx < t.Length)
            {
                if (s[sIdx] == t[tIdx])
                {
                    sIdx++;
                    tIdx++;
                }
                else
                {
                    tIdx++;
                }
                if (sIdx == s.Length)
                    return true;
            }
            return false;
        }
    }
}
