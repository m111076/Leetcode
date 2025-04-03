using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _1637_Widest_Vertical_Area_Between_Two_Points_Containing_No_Points
    {
        public static int MaxWidthOfVerticalArea(int[][] points)
        {
            //runtime 50%
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            var result = 0;
            var preX = points[0][0];

            for (int i = 1; i < points.Length; i++)
            {
                result = Math.Max(result, points[i][0] - preX);
                preX = points[i][0];
            }

            return result;
        }
    }
}
