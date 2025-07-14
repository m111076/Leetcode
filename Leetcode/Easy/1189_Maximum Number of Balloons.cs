using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1189_Maximum_Number_of_Balloons
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MaxNumberOfBalloons(string text)
        {
            var charCount = new int[26];
            foreach (var c in text)
            {
                charCount[c - 'a']++;
            }
            var bCnt = charCount['b' - 'a'];
            var aCnt = charCount['a' - 'a'];
            var l2Cnt = charCount['l' - 'a'] / 2;
            var o2Cnt = charCount['o' - 'a'] / 2;
            var nCnt = charCount['n' - 'a'];

            return Math.Min(Math.Min(bCnt, aCnt), Math.Min(l2Cnt, Math.Min(o2Cnt, nCnt)));
        }
    }
}
