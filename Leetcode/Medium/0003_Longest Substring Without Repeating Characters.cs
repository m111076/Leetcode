using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0003_Longest_Substring_Without_Repeating_Characters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            //使用hashset
            //runtime 80%
            //time complexity O(n)
            //space complexity O(n)
            var left = 0;
            var right = 0;
            var max = 0;
            var set = new HashSet<char>();
            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    max = Math.Max(max, right - left + 1);
                    right++;
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }

            return max;

            //runtime 36%
            //time complexity O(n)
            //space complexity O(n)
            //var left = 0;
            //var right = 0;
            //var max = 0;
            //var dict = new Dictionary<char, int>();

            //for (right = 0; right < s.Length; right++)
            //{
            //    if (dict.ContainsKey(s[right]))
            //    {
            //        dict[s[right]]++;
            //    }
            //    else
            //    {
            //        dict.Add(s[right], 1);
            //    }

            //    while (dict.Count != right - left + 1)
            //    {
            //        dict[s[left]]--;
            //        if (dict[s[left]] == 0)
            //        {
            //            dict.Remove(s[left]);
            //        }
            //        left++;
            //    }

            //    max = Math.Max(max, right - left + 1);
            //}

            //return max;
        }
    }
}
