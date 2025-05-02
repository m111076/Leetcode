using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3325_Count_Substrings_With_K_Frequency_Characters_I
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int NumberOfSubstrings(string s, int k)
        {
            var left = 0;
            var right = 0;
            var arr = new int[128];
            var result = 0;

            while (right < s.Length)
            {
                arr[s[right]]++;

                while (arr[s[right]] == k)
                {
                    arr[s[left++]]--;
                }

                result += left;
                right++;
            }

            return result;
        }
    }
}
