using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1456_Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
    {
        public int MaxVowels(string s, int k)
        {
            //runtime 51%
            //time complexity O(n)
            //space complexity O(1)
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var vowalCount = 0;
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    vowalCount++;
                }

                if (i < k - 1)
                    continue;

                result = Math.Max(result, vowalCount);

                if (vowels.Contains(s[i - k + 1]))
                {
                    vowalCount--;
                }
            }

            return result;
        }
    }
}
