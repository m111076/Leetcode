using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0345_Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            var vowelsStack = new Stack<char>();
            var result = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if ("aeiouAEIOU".Contains(s[i]))
                    vowelsStack.Push(s[i]);
            }

            for (var i = s.Length - 1; i > 0; i--)
            {
                if ("aeiouAEIOU".Contains(s[i]))
                    result.Append(vowelsStack.Pop());
                else
                    result.Append(s[i]);
            }
            return result.ToString();
        }
    }
}
