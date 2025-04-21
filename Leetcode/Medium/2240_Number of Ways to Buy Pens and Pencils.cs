using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2240_Number_of_Ways_to_Buy_Pens_and_Pencils
    {
        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            //runtime 85%
            //time complexity O(n)
            //space complexity O(1)
            //將total除以cost1，得到最多可以買多少支筆，然後用total減去cost1乘以i的值，得到剩下的錢，再除以cost2，得到最多可以買多少支鉛筆，最後加1是因為可以不買鉛筆
            var result = 0L;
            var tmp = total / cost1;

            for (var i = 0; i <= tmp; i++)
            {
                var tmpVal = total - (cost1 * i);
                result += (tmpVal / cost2) + 1;
            }

            return result;
        }
    }
}
