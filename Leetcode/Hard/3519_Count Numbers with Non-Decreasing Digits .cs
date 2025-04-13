using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    //待修改
    //time complexity: O(n*m)
    //space complexity: O(n)
    internal class _3519_Count_Numbers_with_Non_Decreasing_Digits
    {
        const int MOD = 1_000_000_007;

        public int CountNumbers(string l, string r, int b)
        {
            var lowerBound = (BigInteger.Parse(l) - 1).ToString();
            return (int)((CountUpTo(r, b) - CountUpTo(lowerBound, b) + MOD) % MOD);
        }
        private long CountUpTo(string numStr, int b)
        {
            var digits = ToBaseB(numStr, b);
            var memo = new long[digits.Count + 1, b + 1, 2, 2];
            for (int i = 0; i <= digits.Count; i++)
                for (int j = 0; j <= b; j++)
                    for (int k = 0; k < 2; k++)
                        for (int l = 0; l < 2; l++)
                            memo[i, j, k, l] = -1;

            return Dp(0, 0, true, true);

            long Dp(int pos, int prevDigit, bool tight, bool leadingZero)
            {
                if (pos == digits.Count) return leadingZero ? 0 : 1;
                if (memo[pos, prevDigit, tight ? 1 : 0, leadingZero ? 1 : 0] != -1)
                    return memo[pos, prevDigit, tight ? 1 : 0, leadingZero ? 1 : 0];

                var res = 0L;
                var limit = tight ? digits[pos] : b - 1;
                for (int d = 0; d <= limit; d++)
                {
                    if (!leadingZero && d < prevDigit) continue;

                    bool newTight = tight && d == limit;
                    bool newLeadingZero = leadingZero && d == 0;
                    res = (res + Dp(pos + 1, newLeadingZero ? 0 : d, newTight, newLeadingZero)) % MOD;
                }

                return memo[pos, prevDigit, tight ? 1 : 0, leadingZero ? 1 : 0] = res;
            }
        }

        private List<int> ToBaseB(string numStr, int b)
        {
            var num = BigInteger.Parse(numStr);
            var res = new List<int>();
            if (num == 0) return new List<int> { 0 };

            while (num > 0)
            {
                res.Add((int)(num % b));
                num /= b;
            }
            res.Reverse();
            return res;
        }
    }
}
