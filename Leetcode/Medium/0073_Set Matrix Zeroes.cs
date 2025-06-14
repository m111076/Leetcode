using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0073_Set_Matrix_Zeroes
    {
        //runtime 78%
        //time complexity O(m*n)
        //space complexity O(1)
        //使用第一列或第一行來當標記
        //但要先判斷第一行或列有沒有0，有的話要記錄下來，之後改0要用
        public void SetZeroes(int[][] matrix)
        {
            var isRowZreo = false;

            for (var r = 0; r < matrix.Length; r++)
            {
                if (matrix[r][0] == 0)
                    isRowZreo = true;

                for (var c = 1; c < matrix[0].Length; c++)
                {
                    if (matrix[r][c] == 0)
                    {
                        matrix[r][0] = 0;
                        matrix[0][c] = 0;
                    }
                }
            }

            for (var r = matrix.Length - 1; r >= 0; r--)
            {
                for (var c = 1; c < matrix[0].Length; c++)
                {
                    if (matrix[r][0] == 0 || matrix[0][c] == 0)
                        matrix[r][c] = 0;
                }
            }

            if (isRowZreo)
            {
                for (var r = 0; r < matrix.Length; r++)
                {
                    matrix[r][0] = 0;
                }
            }
        }
    }
}
