using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _2131_Longest_Palindrome_by_Concatenating_Two_Letter_Words
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public static int LongestPalindrome(string[] words)
        {
            var sets = new int[26, 26];

            foreach (var word in words)
            {
                sets[word[0] - 'a', word[1] - 'a']++;
            }

            var result = 0;
            var odd = false;

            for (var i = 0; i < 26; i++)
            {
                result += sets[i, i] - sets[i, i] % 2;
                odd |= (sets[i, i] & 1) != 0;
                for (var j = i + 1; j < 26; j++)
                {
                    result += Math.Min(sets[i, j], sets[j, i]) * 2;
                }
            }

            return odd ? (result + 1) * 2 : result * 2;
        }
    }
}
