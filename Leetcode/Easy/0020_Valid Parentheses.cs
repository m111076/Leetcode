using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _20_Valid_Parentheses
    {
        //runtime 81%
        //time complexity O(n)
        //space complexity O(n)
        //先進後出
        public static bool IsValid(string s)
        {
            var cStack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(')
                {
                    cStack.Push(')');
                    continue;
                }
                if (c == '[')
                {
                    cStack.Push(']');
                    continue;
                }
                if (c == '{')
                {
                    cStack.Push('}');
                    continue;
                }
                if (cStack.Count == 0 || cStack.Pop() != c)
                    return false;
            }

            return cStack.Count == 0;
        }
    }

}
