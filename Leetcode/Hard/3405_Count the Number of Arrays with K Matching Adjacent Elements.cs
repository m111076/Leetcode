using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _3405_Count_the_Number_of_Arrays_with_K_Matching_Adjacent_Elements
    {
        //runtime 20%
        //time complexity O(n)
        //space complexity O(n)
        //反模元素= =  a的反模元素=> a^(p-2) mod p
        //太難了
        public int CountGoodArrays(int n, int m, int k)
        {
            var mod = 1_000_000_007;
            var f = new long[n];
            var inverseF = new long[n];

            f[0] = 1;

            for (var i = 1; i < n; i++)
            {
                f[i] = f[i - 1] * i % mod;
            }

            inverseF[n - 1] = Pow(f[n - 1], mod - 2, mod);

            for (var i = n - 1; i > 0; i--)
            {
                inverseF[i - 1] = inverseF[i] * i % mod;
            }

            var combo = (f[n - 1] * inverseF[k] % mod * inverseF[n - 1 - k] % mod) % mod;

            var pow = 1L;

            for (var i = 0; i < n - 1 - k; i++)
            {
                pow = (pow * (m - 1)) % mod;
            }

            return (int)(combo * m % mod * pow % mod);

            long Pow(long x, long n, int mod)
            {
                long res = 1;
                while (n > 0)
                {
                    if ((n & 1) == 1)
                        res = res * x % mod;
                    x = x * x % mod;
                    n >>= 1;
                }
                return res;
            }
        }
    }
}
