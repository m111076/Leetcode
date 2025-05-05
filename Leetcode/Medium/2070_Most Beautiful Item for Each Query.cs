using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2070_Most_Beautiful_Item_for_Each_Query
    {
        //runtime 100%
        //time complexity((i+q)logi)
        public int[] MaximumBeauty(int[][] items, int[] queries)
        {
            Array.Sort(items, (a, b) => a[0] - b[0]);

            for (int i = 1; i < items.Length; i++)
            {
                items[i][1] = Math.Max(items[i][1], items[i - 1][1]);
            }

            var result = new int[queries.Length];

            for (int i = 0; i < result.Length; i++)
            {
                var t = queries[i];

                var r = BS(items, t);
                result[i] = r > 0 ? items[r - 1][1] : 0;
            }

            return result;
        }

        private int BS(int[][] items, int target)
        {
            var left = 0;
            var right = items.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (items[mid][0] > target)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
