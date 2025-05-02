using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal static class _0076_Minimum_Window_Substring
    {
        public static string MinWindow(string s, string t)
        {
            //runtime 17%
            //time complexity O(N)
            //space complexity O(1)
            //滑動視窗
            //用dictionary應該可以減少比對次數
            if (t.Length > s.Length)
                return string.Empty;

            var left = 0;
            var right = 0;
            var tArr = new int[128];
            var sArr = new int[128];
            var result_Length = int.MaxValue;
            var result = string.Empty;

            foreach (char c in t)
            {
                tArr[c]++;
            }


            while (right < s.Length)
            {
                var target = s[right];
                sArr[target]++;

                while (sArr[target] == tArr[target])
                {
                    var IsMatch = true;

                    for (var i = 0; i < 128; i++)
                    {
                        if (sArr[i] < tArr[i])
                        {
                            IsMatch = false;
                            break;
                        }
                    }
                    if (IsMatch)
                    {
                        if (result_Length > right - left + 1)
                        {
                            result_Length = right - left + 1;
                            result = s.Substring(left, result_Length);
                        }
                        sArr[s[left++]]--;
                    }
                    else
                        break;
                }
                right++;
            }

            return result;
        }
    }
}
