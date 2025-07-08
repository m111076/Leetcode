using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1957_Delete_Characters_to_Make_Fancy_String
    {
        //runtime 98%
        //time complexity O(n)
        //sapce complexity O(n)
        public string MakeFancyString(string s)
        {
            if (s.Length == 1)
                return s;

            var result = new StringBuilder();
            char targetChar = '$';
            var cnt = 1;

            foreach (char c in s)
            {
                if (c == targetChar)
                {
                    if (cnt < 2)
                    {
                        result.Append(c);
                        cnt++;
                    }
                }
                else
                {
                    result.Append(c);
                    targetChar = c;
                    cnt = 1;
                }
            }

            return result.ToString();
        }
    }
}
