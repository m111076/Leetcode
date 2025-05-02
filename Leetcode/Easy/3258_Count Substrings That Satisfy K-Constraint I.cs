using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3258_Count_Substrings_That_Satisfy_K_Constraint_I
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        public int CountKConstraintSubstrings(string s, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var oneCnt = 0;
            var zeroCnt = 0;

            while (right < s.Length)
            {
                var t = s[right] == '0' ? zeroCnt++ : oneCnt++;

                while (zeroCnt > k && oneCnt > k)
                {
                    t = s[left++] == '0' ? zeroCnt-- : oneCnt--;
                }
                result += right - left + 1;

                right++;
            }

            return result;
        }
    }
}
