using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3453_Separate_Squares_I
    {
        public double SeparateSquares(int[][] squares)
        {
            var left = double.MaxValue;
            var right = double.MinValue;

            foreach (var square in squares)
            {
                left = Math.Min(left, square[1]);
                right = Math.Max(right, square[1] + square[2]);
            }

            while (right - left > 1e-5)
            {
                var mid = left + (right - left) / 2;

                if (Check(squares, mid))
                    right = mid;
                else
                    left = mid;
            }

            return left;
        }

        //下方是否大於等上方
        private bool Check(int[][] squares, double y)
        {
            var upper = 0d;
            var bottom = 0d;

            foreach (var square in squares)
            {
                if (square[1] + square[2] <= y)
                {
                    bottom += square[2] * square[2];
                }
                else if (y <= square[1])
                {
                    upper += square[2] * square[2];
                }
                else
                {
                    var sq = square[2] * square[2];
                    upper += sq * (square[1] + square[2] - y) / square[2];
                    bottom += sq * (y - square[1]) / square[2];
                }
            }

            return upper <= bottom;
        }
    }
}
