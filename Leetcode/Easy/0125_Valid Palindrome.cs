using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0125_Valid_Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            //沒想到= =
            //var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
            //return clean.Reverse().SequenceEqual(clean);

            //leetcode不給用Regex
            if (s == null) return true;
            s = s.ToLower();

            var temp = Regex.Matches(s, @"[a-z/A-Z]");
            var temp2 = Regex.Matches(s, @"[a-z]");
            var half = temp.Count() / 2;
            for (var i = 0; i < half; i++)
            {
                if (temp[i].Value != temp[temp.Count() - 1 - i].Value)
                    return false;
            }

            return true;
        }
    }
}
