using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 86%
    //time complexity O(n)
    //space complexity O(1)
    //滑動視窗
    internal class _1208_Get_Equal_Substrings_Within_Budget
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            var right = 0;
            var left = 0;
            var result = 0;
            var cost = 0;

            while (right < s.Length)
            {
                var diff = Math.Abs(s[right] - t[right]);
                if (cost + diff > maxCost)
                {
                    var dif = Math.Abs(s[left] - t[left]);
                    cost -= dif;
                    left++;
                }
                else
                {
                    cost += diff;
                    result = Math.Max(result, right - left + 1);
                    right++;
                }
            }

            return result;
        }
    }
}
