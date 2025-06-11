using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0074_Search_a_2D_Matrix
    {
        //runtime 100%
        //time complexity O(log(m*n))
        //space complexity O(1)
        //題目說時間複雜度log(m*n)=logn+logm，很明顯叫你用2次BS
        //用兩次BS，第一次找列，第二次找行
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var left = 0;
            var right = matrix.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (matrix[mid][0] == target)
                {
                    return true;
                }
                else if (matrix[mid][0] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            var row = left - 1;

            if (row < 0)
                return false;

            left = 0;
            right = matrix[row].Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (matrix[row][mid] == target)
                {
                    return true;
                }
                else if (matrix[row][mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return false;
        }
    }
}
