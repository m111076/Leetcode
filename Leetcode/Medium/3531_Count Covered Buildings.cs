using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _3531_Count_Covered_Buildings
    {
        //runtime 84%
        //time complexity O(n)
        //space complexity O(n)
        //分別記錄下每個x和y的上下限
        public static int CountCoveredBuildings(int n, int[][] buildings)
        {
            var xRangeY = new Dictionary<int, int[]>();
            var yRangeX = new Dictionary<int, int[]>();

            foreach (var building in buildings)
            {
                if (yRangeX.ContainsKey(building[1]))
                {
                    yRangeX[building[1]][0] = Math.Min(yRangeX[building[1]][0], building[0]);
                    yRangeX[building[1]][1] = Math.Max(yRangeX[building[1]][1], building[0]);
                }
                else
                {
                    yRangeX.Add(building[1], new int[2] { building[0], building[0] });
                }
                if (xRangeY.ContainsKey(building[0]))
                {
                    xRangeY[building[0]][0] = Math.Min(xRangeY[building[0]][0], building[1]);
                    xRangeY[building[0]][1] = Math.Max(xRangeY[building[0]][1], building[1]);
                }
                else
                {
                    xRangeY.Add(building[0], new int[2] { building[1], building[1] });
                }
            }

            var result = 0;

            foreach (var building in buildings)
            {
                if (!(xRangeY[building[0]][0] < building[1] && building[1] < xRangeY[building[0]][1]))
                    continue;
                if (!(yRangeX[building[1]][0] < building[0] && building[0] < yRangeX[building[1]][1]))
                    continue;
                result++;
            }

            return result;
        }
    }
}
