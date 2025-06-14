using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0054_Spiral_Matrix
    {
        //runtime 100%
        //time complexity O(m*n)
        //space complexity O(1)
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            if (matrix.Length == 0 || matrix[0].Length == 0)
                return result;

            var left = 0;
            var right = matrix[0].Length - 1;
            var top = 0;
            var bottom = matrix.Length - 1;

            while (left <= right && top <= bottom)
            {
                for (var c = left; c <= right; c++)
                {
                    result.Add(matrix[top][c]);
                }
                top++;
                for (var r = top; r <= bottom; r++)
                {
                    result.Add(matrix[r][right]);
                }
                right--;
                if (top <= bottom)
                {
                    for (var c = right; c >= left; c--)
                    {
                        result.Add(matrix[bottom][c]);
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (var r = bottom; r >= top; r--)
                    {
                        result.Add(matrix[r][left]);
                    }
                    left++;
                }
            }

            return result;
        }
    }
}
