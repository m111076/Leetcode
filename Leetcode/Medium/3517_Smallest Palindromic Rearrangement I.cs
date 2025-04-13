using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3517_Smallest_Palindromic_Rearrangement_I
    {
        //
        //time complexity: O(n*m)
        //space complexity: O(n)
        //因為要找出最小的，所以先記錄a~z的用量
        //然後依序由a~z的順序放入frontHalf，在放入的過程中可以判斷是否有奇數項並記錄下來
        //之後將frontHalf反向相加即可得到最小的迴文字串
        public static string SmallestPalindrome(string s)
        {
            var tmp = new int[26];
            foreach (char c in s)
                tmp[c - 'a']++;

            var oddChar = '\0';
            var frontHalf = new StringBuilder();

            for (int i = 0; i < 26; i++)
            {
                if ((tmp[i] & 1) == 1)
                    oddChar = (char)(i + 'a');

                for (int j = 0; j < tmp[i] / 2; j++)
                {
                    frontHalf.Append((char)(i + 'a'));
                }
            }

            var frontStr = frontHalf.ToString();
            var backStr = new string(frontHalf.ToString().ToCharArray().Reverse().ToArray());
            var midStr = (oddChar != '\0') ? oddChar.ToString() : "";

            return frontStr + midStr + backStr;
        }
    }
}
