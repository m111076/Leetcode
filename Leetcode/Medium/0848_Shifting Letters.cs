using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0848_Shifting_Letters
    {
        //runtime 83%
        //time complexity O(n)
        //space complexity O(n)
        //由後往前，並且累加數值再取26的餘數
        public string ShiftingLetters(string s, int[] shifts)
        {
            var step = 0;
            var result = new char[s.Length];

            for (var i = shifts.Length - 1; i >= 0; i--)
            {
                step += shifts[i];
                step %= 26;

                var target = s[i] - 'a';
                var tmp = (target + step) % 26;

                result[i] = (char)(tmp + 'a');
            }

            return new string(result);
        }
    }
}
