using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0492_Construct_the_Rectangle
    {
        public int[] ConstructRectangle(int area)
        {
            //
            var mid = (int)Math.Sqrt(area);
            var between = int.MaxValue;

            for (var i = mid; i >= 1; i--)
            {
                if (area % i == 0)
                {
                    return new int[] { area / i, i };
                }
            }
            return new int[] { area, 1 };

            //runtime38%
            //var half = Math.Sqrt(area);
            //var result = new int[2];
            //var between = int.MaxValue;

            //for (var i = 1; i <= half; i++)
            //{
            //    if (area % i == 0)
            //    {
            //        var target = area / i;
            //        if (target - i < between)
            //        {
            //            between = target - i;
            //            result[0] = target;
            //            result[1] = i;
            //        }
            //    }
            //}
            //return result;
        }
    }
}
