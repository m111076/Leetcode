using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2594_Minimum_Time_to_Repair_Cars
    {

        //使用終止條件
        //runtime 68%
        public long RepairCars(int[] ranks, int cars)
        {
            var left = 0L;
            var right = (long)ranks.Max() * cars * cars;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(ranks, mid, cars))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private bool Check(int[] ranks, long time, int cars)
        {
            var result = 0L;

            foreach (var rank in ranks)
            {
                result += (long)(Math.Sqrt(time / rank));
                if (result >= cars)
                    return true;
            }
            return false;
        }

        //runtime 33%
        //time comlexity O(logn*R)
        //public long RepairCars(int[] ranks, int cars)
        //{
        //    var left = 0L;
        //    var right = (long)ranks.Max() * cars * cars;

        //    while (left < right)
        //    {
        //        var mid = left + (right - left) / 2;

        //        if (Check(ranks, mid) >= cars)
        //            right = mid;
        //        else
        //            left = mid + 1;
        //    }

        //    return left;
        //}

        //private long Check(int[] ranks, long time)
        //{
        //    var result = 0L;

        //    foreach (var rank in ranks)
        //    {
        //        result += (long)(Math.Sqrt(time / rank));
        //    }
        //    return result;
        //}
    }
}
