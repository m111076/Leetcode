using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2375_Construct_Smallest_Number_From_DI_String
    {
        /// <summary>
        /// Stack LIFO
        /// 前一個為I時全部POP出，若為D則繼續直到遇到邊界或是出現I
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string SmallestNumber(string pattern)
        {
            var l = pattern.Length;
            var stack = new Stack<int>();
            var result = "";

            for (var i = 0; i <= l; i++)
            {
                stack.Push(i + 1);

                //合併在一起判斷比多掛一層快 但pattern[i]在邊界時會出錯所以放右側
                if (i == l || pattern[i] == 'I')
                {
                    while (stack.Count > 0)
                    {
                        result += stack.Pop();
                    }
                }
            }

            return result;
        }
    }
}
