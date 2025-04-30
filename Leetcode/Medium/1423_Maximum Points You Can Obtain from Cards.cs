using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _1423_Maximum_Points_You_Can_Obtain_from_Cards
    {
        public static int MaxScore(int[] cardPoints, int k)
        {
            //runtime 36%
            //time complexity O(n)
            //space complexity O(n)
            var n = cardPoints.Length;
            var tmp = cardPoints.Concat(cardPoints).ToArray();
            var sum = 0;
            var result = 0;
            var length = n + k;

            for (var i = n - k; i < n + k; i++)
            {
                sum += tmp[i];

                if (i < n - 1)
                    continue;

                result = Math.Max(result, sum);

                sum -= tmp[i - k + 1];
            }

            return result;
        }
    }
}
