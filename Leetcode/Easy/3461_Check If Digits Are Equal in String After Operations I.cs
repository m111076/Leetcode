using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _3461_Check_If_Digits_Are_Equal_in_String_After_Operations_I
    {
        public static bool HasSameDigits(string s)
        {
            var length = s.Length;
            var result = string.Empty;

            while (s.Length > 2)
            {
                var tmp = 0;

                for (var i = 0; i < s.Length - 1; i++)
                {
                    tmp += int.Parse(s[i].ToString());
                    tmp += int.Parse(s[i + 1].ToString());
                    result += (tmp % 10).ToString();
                    tmp = 0;
                }

                s = result;
            }

            return s[0] == s[1];
        }
    }
}
