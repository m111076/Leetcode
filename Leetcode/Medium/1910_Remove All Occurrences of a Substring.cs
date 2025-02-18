using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _1910_Remove_All_Occurrences_of_a_Substring
    {
        public static string RemoveOccurrences(string s, string part)
        {
            //while (s.Contains(part))
            //{
            //    s = s.Remove(s.IndexOf(part), part.Length);
            //}
            //return s;

            //效能的極致
            var m = part.Length;
            var index = 0;

            while ((index = s.IndexOf(part, StringComparison.Ordinal)) != -1)
            {
                s = s[..index] + s[(index + m)..];
            }

            return s;
        }
    }
}
