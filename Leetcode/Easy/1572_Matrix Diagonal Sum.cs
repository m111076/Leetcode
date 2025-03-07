using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1572_Matrix_Diagonal_Sum
    {
        public int DiagonalSum(int[][] mat)
        {
            //runtime 100%
            //奇數中間重複一次，須減掉
            if (mat.Length == 1) return mat[0][0];

            var isOdd = (mat.Length % 2) == 0;
            var length = mat.Length;
            var result = 0;

            for (var i = 0; i < length; i++)
            {
                result += mat[i][i];
                result += mat[length - 1 - i][i];
            }

            if (!isOdd)
            {
                result -= mat[length / 2][length / 2];
            }
            return result;
        }
    }
}
