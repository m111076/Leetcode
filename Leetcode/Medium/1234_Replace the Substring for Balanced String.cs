using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1234_Replace_the_Substring_for_Balanced_String
    {
        //runtime 79%
        //time complexity O(N)
        //space complexity O(1)
        //滑動視窗
        //先計算過QWER的數量
        //結著移動右指標，將出現的char做為可以調整的
        //當剩下的QWER數量皆小於balance時，代表可以透過左側的window內的chars調整成整體balance的狀態
        //反覆比較此window的長度
        public int BalancedString(string s)
        {
            var left = 0;
            var right = 0;
            var result = int.MaxValue;
            var balance = s.Length / 4;
            var cArr = new int[128];

            foreach (var c in s)
            {
                cArr[c]++;
            }

            while (right < s.Length)
            {
                cArr[s[right]]--;

                while (left < s.Length && cArr['Q'] <= balance && cArr['W'] <= balance && cArr['E'] <= balance && cArr['R'] <= balance)
                {
                    result = Math.Min(result, right - left + 1);
                    cArr[s[left++]]++;
                }

                right++;
            }

            return result;
        }
    }
}
