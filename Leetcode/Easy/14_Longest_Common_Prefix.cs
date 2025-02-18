using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _14_Longest_Common_Prefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string shortest = strs.OrderBy(s => s.Length).First();
            var l = shortest.Length;

            for (int i = 0; i < l; i++)
            {
                if (strs.Select(s => s[i]).Distinct().Count() > 1)
                    return shortest[..i];
            }

            return shortest;
        }
    }
}
