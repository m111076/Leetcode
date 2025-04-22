using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 74%
    //time complexity O(n)
    //space complexity O(1) 
    internal class _1400_Construct_K_Palindrome_Strings
    {
        public bool CanConstruct(string s, int k)
        {
            var cArr = new int[26];
            var target = k;

            foreach (var c in s)
            {
                cArr[c - 'a']++;
            }

            for (var i = 0; i < cArr.Length; i++)
            {
                if (cArr[i] % 2 == 1)
                {
                    k--;
                }
            }

            return target <= s.Length && k >= 0;
        }
    }
}
