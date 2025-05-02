using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _2904_Shortest_and_Lexicographically_Smallest_Beautiful_String
    {
        //runtime 100%
        //Time Complexity O(N)
        //Space complexity O(1)
        public static string ShortestBeautifulSubstring(string s, int k)
        {
            var left = 0;
            var right = 0;
            var oneCnt = 0;
            var result_Length = int.MaxValue;
            var result = string.Empty;


            while (right < s.Length)
            {
                if (s[right] == '1')
                    oneCnt++;

                while (oneCnt == k)
                {
                    if (right - left + 1 < result_Length)
                    {
                        result_Length = right - left + 1;
                        result = s.Substring(left, result_Length);
                    }
                    else if (right - left + 1 == result_Length)
                    {
                        result_Length = right - left + 1;
                        var idxNew = left;
                        var idxOld = 0;

                        while (idxOld < result.Length && result[idxOld] == s[idxNew])
                        {
                            idxOld++;
                            idxNew++;
                        }

                        if (idxOld < result.Length)
                            result = result[idxOld] == '0' ? result : s.Substring(left, result_Length);
                    }
                    if (s[left++] == '1')
                        oneCnt--;
                }
                right++;
            }

            return result;
        }
    }
}
