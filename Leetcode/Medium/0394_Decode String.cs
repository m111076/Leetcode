using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0394_Decode_String
    {
        //runtime 92%
        //time complexity O(m)
        //space complexity O(n+m)
        public string DecodeString(string s)
        {
            var numStack = new Stack<int>();
            var strStack = new Stack<string>();
            var currentString = new StringBuilder();
            var currentNum = 0;

            foreach (var c in s)
            {
                if (Char.IsDigit(c))
                {
                    currentNum = currentNum * 10 + (c - '0');
                }
                else if (c == '[')
                {
                    numStack.Push(currentNum);
                    strStack.Push(currentString.ToString());
                    currentString.Clear();
                    currentNum = 0;
                }
                else if (c == ']')
                {
                    var repeatCount = numStack.Pop();
                    var previousString = strStack.Pop();
                    var tmp = new StringBuilder(previousString);

                    for (int i = 0; i < repeatCount; i++)
                    {
                        tmp.Append(currentString);
                    }
                    currentString = tmp;

                }
                else
                {
                    currentString.Append(c);
                }
            }

            return currentString.ToString();
        }
    }
}
