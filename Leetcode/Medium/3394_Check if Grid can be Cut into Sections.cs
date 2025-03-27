using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3394_Check_if_Grid_can_be_Cut_into_Sections
    {
        public bool CheckValidCuts(int n, int[][] rectangles)
        {
            //runtime 87%
            //先將所有矩形的邊界分開
            //將xBoundary和yBoundary分別排序
            //檢查xBoundary和yBoundary是否有超過2個以上的斷點
            var xBoundary = rectangles.Select(x => new[] { x[0], x[2] }).ToArray();
            var yBoundary = rectangles.Select(x => new[] { x[1], x[3] }).ToArray();

            Array.Sort(xBoundary, (x, y) => x[0].CompareTo(y[0]));
            Array.Sort(yBoundary, (x, y) => x[0].CompareTo(y[0]));

            return Check(xBoundary) || Check(yBoundary);

            bool Check(int[][] iBoundarys)
            {
                var cnt = 0;
                var maxBoundary = iBoundarys[0][1];

                foreach (var boundary in iBoundarys)
                {
                    if (maxBoundary <= boundary[0])
                        cnt++;
                    maxBoundary = Math.Max(maxBoundary, boundary[1]);
                }

                return cnt > 2;
            }
        }
    }
}
