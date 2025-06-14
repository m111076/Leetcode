using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0240_Search_a_2D_Matrix_II
    {
        //runtime 75%
        //time complexity O(m+n)
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = 0;
            var col = matrix[0].Length - 1;

            while (row < matrix.Length && col >= 0)
            {
                if(matrix[row][col] == target)
                {
                    return true;
                }
                else if (matrix[row][col] > target)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return false;
        }

        //runtime 17%
        //time complexity O(log(m*n))
        //space complexity O(1)
        //public bool SearchMatrix(int[][] matrix, int target)
        //{
        //    var left = 0;
        //    var right = matrix.Length;

        //    while (left < right)
        //    {
        //        var mid = left + (right - left) / 2;

        //        if (matrix[mid][0] > target)
        //        {
        //            right = mid;
        //        }
        //        else if (matrix[mid][0] < target)
        //        {
        //            left = mid + 1;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }

        //    var rowMax = left;

        //    for (var r = 0; r < rowMax; r++)
        //    {
        //        right = matrix[r].Length;
        //        left = 0;

        //        while (left < right)
        //        {
        //            var mid = left + (right - left) / 2;

        //            if (matrix[r][mid] > target)
        //            {
        //                right = mid;
        //            }
        //            else if (matrix[r][mid] < target)
        //            {
        //                left = mid + 1;
        //            }
        //            else
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    return false;

        //}
    }
}
