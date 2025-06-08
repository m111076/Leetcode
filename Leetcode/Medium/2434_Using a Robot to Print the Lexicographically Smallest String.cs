using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2434_Using_a_Robot_to_Print_the_Lexicographically_Smallest_String
    {
        //runtime 55%
        //time complexity O(n+1*n) O(n)
        //space complexity O(1)
        //先記錄每個字母出現的次數，然後用一個堆疊來存放當前的字母，當前字母小於堆疊頂部的字母時，就將堆疊頂部的字母加入結果，否則就將當前字母加入堆疊。
        public static string RobotWithString(string s)
        {
            var chars = new int[26];
            var stack = new Stack<char>();
            var result = new StringBuilder();

            foreach (char ch in s)
            {
                chars[ch - 'a']++;
            }

            var idx = 0;

            for (var i = 0; i < chars.Length; i++)
            {
                while (chars[i] != 0)
                {
                    while (stack.Count > 0 && stack.Peek() <= (char)(i + 'a'))
                    {
                        result.Append(stack.Pop());
                    }

                    if (s[idx] - 'a' != i)
                    {
                        stack.Push((char)(s[idx]));
                        chars[s[idx] - 'a']--;
                    }
                    else
                    {
                        result.Append((char)(i + 'a'));
                        chars[i]--;
                    }
                    idx++;
                }
            }

            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }

            return result.ToString();
        }
    }
}
