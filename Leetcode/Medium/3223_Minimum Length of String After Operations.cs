using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3223_Minimum_Length_of_String_After_Operations
    {
        //runtime 91%
        //time complexity O(s)
        //space complexity O(1)
        public int MinimumLength(string s)
        {
            var result = 0;
            var chars = new int[26];

            foreach (char c in s)
            {
                chars[c - 'a']++;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                result += (chars[i] - 1) % 2 + 1;
            }

            return result;
        }
    }
}
