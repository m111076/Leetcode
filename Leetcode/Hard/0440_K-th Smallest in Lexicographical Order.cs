using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal static class _0440_K_th_Smallest_in_Lexicographical_Order
    {
        private static int cnt = 0;
        private static int result = 0;

        public static int FindKthNumber(int n, int k)
        {
            for (var i = 1; i <= 9; i++)
            {
                DFS(i, n, k);

                if (cnt >= k)
                    break;
            }
            return result;
        }

        private static void DFS(int current, int n, int k)
        {
            if (cnt >= k || current > n)
                return;

            if (++cnt == k)
            {
                result = current;
                return;
            }

            for (var i = 0; i <= 9; i++)
            {
                var next = current * 10 + i;
                if (next > n)
                    break;
                DFS(next, n, k);
            }
        }
    }
}
