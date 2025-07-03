using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3598_Longest_Common_Prefix_Between_Adjacent_Strings_After_Removals
    {
        public int[] LongestCommonPrefix(string[] words)
        {
            //runtime 67%
            //time complexity O(n*L)
            //sapce complexity O(n)
            var pre = new int[words.Length];
            var suf = new int[words.Length];
            var result = new int[words.Length];
            var tmpMax = 0;

            for (int i = 2; i < words.Length; i++)
            {
                tmpMax = Math.Max(tmpMax, LCP(words[i - 1], words[i - 2]));
                pre[i] = tmpMax;
            }

            tmpMax = 0;
            for (var i = words.Length - 3; i >= 0; i--)
            {
                tmpMax = Math.Max(tmpMax, LCP(words[i + 1], words[i + 2]));
                suf[i] = tmpMax;
            }

            for (var i = 0; i < words.Length; i++)
            {
                if (i == 0 || i == words.Length - 1)
                    result[i] = Math.Max(pre[i], suf[i]);
                else
                {
                    result[i] = Math.Max(LCP(words[i - 1], words[i + 1]), Math.Max(pre[i], suf[i]));
                }
            }

            return result;
        }

        private int LCP(string iStr1, string iStr2)
        {
            var minL = Math.Min(iStr1.Length, iStr2.Length);

            for (var i = 0; i < minL; i++)
            {
                if (iStr1[i] != iStr2[i])
                    return i;
            }

            return minL;
        }
    }
}
