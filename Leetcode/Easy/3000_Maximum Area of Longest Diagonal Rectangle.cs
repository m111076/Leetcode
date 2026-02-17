using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3000_Maximum_Area_of_Longest_Diagonal_Rectangle
    {
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            var result = int.MinValue;
            var diagonal = double.MinValue;

            foreach (var dim in dimensions)
            {
                var tmpD = Math.Pow(dim[0], 2) + Math.Pow(dim[1], 2);

                if (tmpD > diagonal)
                {
                    diagonal = tmpD;
                    result = dim[0] * dim[1];
                }
                else if (tmpD == diagonal)
                {
                    result = Math.Max(result, dim[0] * dim[1]);
                }
            }

            return result;
        }
    }
}
