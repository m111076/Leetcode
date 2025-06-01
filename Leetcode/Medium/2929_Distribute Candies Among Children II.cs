using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 75%
    //time complexity O(1)
    //space complexity O(1)
    //數學推導
    //組合問題
    //將N個糖果分給3個人等 同於用兩個版子來分割
    //等於C(N+2,2)
    //AUBUC = A+B+C-A∩B-A∩C-B∩C+A∩B∩C
    internal class _2929_Distribute_Candies_Among_Children_II
    {
        public long DistributeCandies(int n, int limit)
        {
            return Cal(n + 2) - 3 * Cal(n - limit + 1) + 3 * Cal(n - (limit + 1) * 2 + 2) - Cal(n - 3 * (limit + 1) + 2);
        }

        public long Cal(int x)
        {
            if (x < 0)
            {
                return 0;
            }
            return (long)x * (x - 1) / 2;
        }
    }
}
