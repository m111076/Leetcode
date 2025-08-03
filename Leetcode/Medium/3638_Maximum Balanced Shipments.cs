using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3638_Maximum_Balanced_Shipments
    {
        public int MaxBalancedShipments(int[] weight)
        {
            var length = weight.Length;
            var result = 0;
            var left = 0;

            while (left < length)
            {
                var max = weight[left];
                var right = left + 1;

                while (right < length)
                {
                    max = Math.Max(max, weight[right]);
                    if (weight[right] < max)
                    {
                        result++;
                        left = right + 1;
                        break;
                    }
                    right++;
                }

                if (right == length) break;
            }

            return result;
        }
    }
}
