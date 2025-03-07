using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2133_Check_if_Every_Row_and_Column_Contains_All_Numbers
    {
        public bool CheckValid(int[][] matrix)
        {
            //runtime 64%
            //讀到第一次的時候+1;不是0的話return false
            var length = matrix.Length;

            for (var i = 0; i < length; i++)
            {
                var row = new int[length + 1];
                var col = new int[length + 1];

                for (var j = 0; j < length; j++)
                {
                    if (row[matrix[i][j]] == 0)
                        row[matrix[i][j]]++;
                    else
                        return false;
                }

                for (var j = 0; j < length; j++)
                {
                    if (col[matrix[j][i]] == 0)
                        col[matrix[j][i]]++;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
