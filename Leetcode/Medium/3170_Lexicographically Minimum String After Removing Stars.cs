using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _3170_Lexicographically_Minimum_String_After_Removing_Stars
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //紀錄位置
        public static string ClearStars(string s)
        {
            var chars = new Stack<int>[26];
            var removeIdx = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    removeIdx[i] = true;

                    for (int j = 0; j < 26; j++)
                    {
                        if (chars[j] != null && chars[j].Count > 0)
                        {
                            removeIdx[chars[j].Pop()] = true;
                            break;
                        }
                    }

                }
                else
                {
                    int idx = s[i] - 'a';
                    if (chars[idx] == null)
                    {
                        chars[idx] = new Stack<int>();
                    }
                    chars[idx].Push(i);
                }
            }

            var sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (!removeIdx[i])
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
