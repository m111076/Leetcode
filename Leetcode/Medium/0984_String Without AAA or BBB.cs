using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _0984_String_Without_AAA_or_BBB
    {
        //runtime 60%
        public static string StrWithout3a3b(int a, int b)
        {
            var result = new StringBuilder();
            var more = a;
            var less = b;
            var moreChar = 'a';
            var lessChar = 'b';

            if (a < b)
            {
                more = b;
                less = a;
                moreChar = 'b';
                lessChar = 'a';
            }

            while (more > 0)
            {
                result.Append(moreChar);
                more--;
                if (more > less)
                {
                    result.Append(moreChar);
                    more--;
                }
                if (less > 0)
                {
                    result.Append(lessChar);
                    less--;
                }
            }

            return result.ToString();
        }
    }
}
