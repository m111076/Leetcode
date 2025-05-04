using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _1170_Compare_Strings_by_Frequency_of_the_Smallest_Character
    {
        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var chars = new int[words.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = check(words[i]);
            }
            Array.Sort(chars);

            var s_queries = new int[queries.Length];

            for (int i = 0; i < s_queries.Length; i++)
            {
                s_queries[i] = check(queries[i]);
            }

            var result = new int[s_queries.Length];

            for (int i = 0; i < s_queries.Length; i++)
            {
                result[i] = chars.Length - checkIdx(chars, s_queries[i]);
            }

            return result;

        }

        private static int checkIdx(int[] ints, int target)
        {
            var left = 0;
            var right = ints.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (ints[mid] > target)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private static int  check(string strs)
        {
            var target = int.MaxValue;
            var cnt = 0;

            foreach (var word in strs)
            {
                if (word < target)
                {
                    target = word;
                    cnt = 1;
                }
                else if (word == target)
                    cnt++;
            }

            return cnt;
        }
    }
}
