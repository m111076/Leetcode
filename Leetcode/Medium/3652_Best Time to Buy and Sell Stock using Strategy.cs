using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3652_Best_Time_to_Buy_and_Sell_Stock_using_Strategy
    {
        //runtime 52%
        //time complexity O(n)
        //space complexity O(n)
        public long MaxProfit(int[] prices, int[] strategy, int k)
        {
            var prefixSum = new long[prices.Length + 1];
            var prefixCellSum = new long[prices.Length + 1];

            for (var i = 0; i < prices.Length; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + prices[i] * strategy[i];
                prefixCellSum[i + 1] = prefixCellSum[i] + prices[i];
            }

            var result = prefixSum[prices.Length];
            var max = prices.Length - k / 2;
            for (var i = k / 2; i <= max; i++)
            {
                result = Math.Max(result, prefixSum[i - k / 2] + prefixCellSum[i + k / 2] - prefixCellSum[i] + prefixSum[prices.Length] - prefixSum[i + k / 2]);
            }

            return result;
        }
    }
}
