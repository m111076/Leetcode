using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0344_Reverse_String
    {
        public static void ReverseString(char[] s)
        {
            //runtime 100%
            //也可以用Array.Reverse(s)
            var half = s.Length / 2;
            for (var i = 0; i < half; i++)
            {
                var tmp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = tmp;
            }
        }
    }
}
