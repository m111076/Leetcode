using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _0440_K_th_Smallest_in_Lexicographical_Order
    {
        public int FindKthNumber(int n, int k)
        {
            var current = 1; 
            k--;

            while (k > 0)
            {
                var steps = Count(n, current, current + 1);

                if (steps <= k)
                {
                    current++;
                    k -= (int)steps;
                }
                else
                {
                    current *= 10;
                    k--;
                }
            }

            return current;
        }

        private long Count(int n, long current, long next)
        {
            var step = 0L;

            while (current <= n)
            {
                step += Math.Min(n + 1, next) - current;
                current *= 10;
                next *= 10;
            }

            return step;
        }

        //可以作但會超時
        //private static int cnt = 0;
        //private static long result = 0;

        //public static int FindKthNumber(int n, int k)
        //{
        //    for (var i = 1; i <= 9; i++)
        //    {
        //        DFS(i, n, k);

        //        if (cnt >= k)
        //            break;
        //    }
        //    return (int)result;
        //}

        //private static void DFS(long current, int n, int k)
        //{
        //    if (cnt >= k || current > n)
        //        return;

        //    if (++cnt == k)
        //    {
        //        result = current;
        //        return;
        //    }

        //    for (var i = 0; i <= 9; i++)
        //    {
        //        var next = current * 10 + i;
        //        if (next > n)
        //            break;
        //        DFS(next, n, k);
        //    }
        //}
    }
}
