using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3628_Maximum_Number_of_Subsequences_After_One_Inserting
    {
        public long NumOfSubsequences(string s)
        {
            var LCT = FindDistinct(s, "LCT");
            var LC = FindDistinct(s, "LC");
            var CT = FindDistinct(s, "CT");
            var T_Cnt = 0L;
            foreach (var c in s)
            {
                if (c == 'T')
                    T_Cnt++;
            }

            var LT = 0L;
            var L_Cnt = 0L;
            foreach (var c in s)
            {
                if (c == 'L')
                    L_Cnt++;
                else if (c == 'T')
                    T_Cnt--;
                LT = Math.Max(LT, L_Cnt * T_Cnt);
            }

            return Math.Max(LC, Math.Max(CT, LT)) + LCT;
        }

        private long FindDistinct(string iStr, string iTarget)
        {
            var s = iStr.Length;
            var t = iTarget.Length;
            if (s < t)
                return 0;

            var f = new long[t + 1];
            f[0] = 1;

            for (var i = 0; i < s; i++)
            {
                for (var j = Math.Min(i, t - 1); j >= Math.Max(t - s + i, 0); j--)
                {
                    if (iStr[i] == iTarget[j])
                        f[j + 1] += f[j];
                }
            }
            return f[t];
        }
    }
}
