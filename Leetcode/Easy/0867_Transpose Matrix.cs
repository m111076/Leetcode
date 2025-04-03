using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0867_Transpose_Matrix
    {
        //runtime 100%
        public int[][] Transpose(int[][] matrix)
        {
            var r = matrix.Length;
            var c = matrix[0].Length;
            var result = new int[c][];

            for (var i = 0; i < c; i++)
            {
                result[i] = new int[r];

                for (var j = 0; j < r; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }
    }
}
