using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3614_Process_String_with_Special_Operations_II
    {
        public char ProcessStr(string s, long k)
        {
            var length = 0L;
            foreach (var c in s)
            {
                if (c == '*')
                    length = length > 0 ? length - 1 : 0;
                else if (c == '#')
                    length *= 2;
                else if (c != '%')
                    length++;
            }

            if (k >= length)
                return '.';

            char result = '.';

            for (var i = s.Length - 1; i >= 0; i--)
            {
                var c = s[i];

                if (c == '*')
                {
                    length++;
                }
                else if (c == '#')
                {
                    length /= 2;
                    if (k >= length)
                        k -= length;
                }
                else if (c == '%')
                {
                    k = length - k - 1;
                }
                else
                {
                    length--;
                    if (length == k)
                    {
                        result = c;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
