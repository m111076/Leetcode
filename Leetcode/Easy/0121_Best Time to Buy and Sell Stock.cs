using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            //TimeLimit O(N!)
            //var max = 0;
            //for (var i = 0; i < prices.Length; i++)
            //{
            //    var temp = Check(i);
            //    max = temp > max ? temp : max;
            //}

            //return max;

            //int Check(int iStart)
            //{
            //    var result = 0;
            //    for (var i = iStart + 1; i < prices.Length; i++)
            //    {
            //        var temp = prices[i] - prices[iStart];
            //        result = temp > result ? temp : result;
            //    }
            //    return result;
            //}

            //O(N)有料= =
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int currentPrice in prices)
            {
                minPrice = Math.Min(currentPrice, minPrice);
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
            }

            return maxProfit;
        }
    }
}
