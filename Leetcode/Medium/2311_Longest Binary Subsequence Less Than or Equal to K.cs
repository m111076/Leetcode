using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2311_Longest_Binary_Subsequence_Less_Than_or_Equal_to_K
    {
        public int LongestSubsequence(string s, int k)
        {
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var sL = s.Length;
            var prefixZeroCnt = 0;

            for (var i = 31; i >= 0; i--)
            {
                if (((k >> i) & 1) == 0)
                    prefixZeroCnt++;
                else
                    break;
            }

            var kL = 32 - prefixZeroCnt;

            if (kL > sL)
                return sL;

            var tmp = Convert.ToInt32(s.Substring(sL - kL), 2);
            var result = tmp <= k ? kL : kL - 1;

            for (var i = 0; i < sL - kL; i++)
            {
                if (s[i] == '0')
                    result++;
            }

            return result;
        }
    }
}
