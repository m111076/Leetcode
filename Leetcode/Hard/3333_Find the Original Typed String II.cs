using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3333_Find_the_Original_Typed_String_II
    {
        //runtime 100%
        //time complexity O(n+k^2)
        //space complexity O(k^2)
        public int PossibleStringCount(string word, int k)
        {
            if (word.Length < k)
                return 0;

            var section = new List<int>();
            var mod = 1000000007;
            var result = 1L;
            var cnt = 0;

            //計算分段長度，因為每個分段要大於1才有額外選擇的必要，因此只有大於1才要加入section中
            for (int i = 0; i < word.Length; i++)
            {
                cnt++;
                if (i == word.Length - 1 || word[i] != word[i + 1])
                {
                    if (cnt > 1)
                    {
                        section.Add(cnt - 1);
                        result = result * cnt % mod;
                    }
                    k--;
                    cnt = 0;
                }
            }
            //分段數已經大於k了，所以不管怎麼選都一定會大於k
            if (k <= 0)
                return (int)result;

            var sCnt = section.Count;
            var dp = new int[sCnt + 1, k];
            var preSum = new int[k + 1];

            //狀態初始化，不管有幾個分段，選0種的方法只有1個(不取)
            for (var i = 0; i < k; i++)
            {
                dp[0, i] = 1;
            }

            for (var i = 0; i < sCnt; i++)
            {
                for (var j = 0; j < k; j++)
                {
                    preSum[j + 1] = (preSum[j] + dp[i, j]) % mod;
                }

                var amount = section[i];

                for (var j = 0; j < k; j++)
                {
                    dp[i + 1, j] = (preSum[j + 1] - preSum[Math.Max((j - amount), 0)] + mod) % mod;
                }
            }

            return (int)((result - dp[sCnt, k - 1] + mod) % mod);
        }
    }
}
