using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _20_Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            //var k = new Stack<char>();

            //foreach (char c in s)
            //{
            //    if (c == '(') { k.Push(')'); continue; }
            //    if (c == '{') { k.Push('}'); continue; }
            //    if (c == '[') { k.Push(']'); continue; }
            //    if (k.Count == 0 || c != k.Pop()) return false;
            //}
            //return k.Count == 0;

            //var l = s.Length;
            //var hL = l / 2;
            //for (var i = 0; i < hL; i++)
            //{
            //    var idx = i * 2 + 1;
            //    if (s[idx].ToString() == LeftGetRight(s[i * 2].ToString()))
            //        continue;
            //    else
            //        return false;
            //}
            //return true;

            var tempS = string.Empty;

            foreach (char c in s)
            {
                if (c == ')')
                {
                    if (!tempS.Contains("("))
                        return false;
                }
                else if (c == '}')
                {
                    if (!tempS.Contains("{"))
                        return false;
                }
                else if (c == ']')
                {
                    if (!tempS.Contains("["))
                        return false;
                }
                else
                {
                    tempS += c;
                }
            }
            return true;
        }

        public string LeftGetRight(string s)
        {
            switch (s)
            {
                case "(":
                    return ")";
                case "{":
                    return "}";
                case "[":
                    return "]";
            }
            return null;
        }
    }

}
