using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3143_Maximum_Points_Inside_the_Square
    {
        //runtime 50%
        //time complexity O(logn*n)
        //space complexity O(1)
        //先用BS計算不會包含重複點的最大值
        //最後再算一次點的數量
        public int MaxPointsInsideSquare(int[][] points, string s)
        {
            var max = -1;

            foreach (var pt in points)
            {
                max = Math.Max(max, Math.Max(Math.Abs(pt[0]), Math.Abs(pt[1])));
            }

            var left = 1;
            var right = max + 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (!Check(mid, points, s))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            var result = 0;

            foreach (var pt in points)
            {
                if(Math.Abs(pt[0]) <= left - 1 && Math.Abs(pt[1]) <= left - 1)
                {
                    result++;
                }
            }

            return result;
        }

        private bool Check(int mid, int[][] points, string s)
        {
            var set = new HashSet<char>();

            for (var i = 0; i < points.Length; i++)
            {
                {
                    var x = points[i][0];
                    var y = points[i][1];
                    if (Math.Abs(x) <= mid && Math.Abs(y) <= mid)
                    {
                        if (set.Contains(s[i]))
                            return false;
                        else
                            set.Add(s[i]);
                    }
                }
            }
            return true;
        }
    }
}
