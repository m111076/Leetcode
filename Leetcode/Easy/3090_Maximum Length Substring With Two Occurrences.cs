using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3090_Maximum_Length_Substring_With_Two_Occurrences
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        public int MaximumLengthSubstring(string s)
        {
            var left = 0;
            var right = 0;
            var result = int.MinValue;
            var cArr = new int[26];

            while (right < s.Length)
            {
                var c = s[right] - 'a';

                if (cArr[c] + 1 <= 2)
                {
                    cArr[c]++;
                    result = Math.Max(result, right - left + 1);
                    right++;
                }
                else
                {
                    var t = s[left++] - 'a';
                    cArr[t]--;
                }
            }

            return result;
        }
    }
}