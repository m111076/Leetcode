using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3614_Process_String_with_Special_Operations_II
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //先順向計算出總長度，接著逆向回推
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
                    if (k >= length)//這邊主要是計算出目標k是由誰複製而來的，等於時並不是解答
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
