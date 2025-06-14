using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{   //runtime 100%
    //time complexity O(n^2)
    //space complexity O(1)
    //透過兩次轉換來達成旋轉90度
    //先對角線互換，在進行行的左右互換
    internal class _0048_Rotate_Image
    {
        public void Rotate(int[][] matrix)
        {
            for (var r = 0; r < matrix.Length; r++)
            {
                for (var c = 0; c < r; c++)
                {
                    var tmp = matrix[r][c];
                    matrix[r][c] = matrix[c][r];
                    matrix[c][r] = tmp;
                }
            }
            var half = matrix.Length / 2;

            for (var r = 0; r < matrix.Length; r++)
            {
                for (var c = 0; c < half; c++)
                {
                    var tmp = matrix[r][c];
                    matrix[r][c] = matrix[r][matrix.Length - 1 - c];
                    matrix[r][matrix.Length - 1 - c] = tmp;
                }
            }
        }
    }
}
