using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2033_Minimum_Operations_to_Make_a_Uni_Value_Grid
    {
        public int MinOperations(int[][] grid, int x)
        {
            //runtime 48%
            //有機會提早終止減少計算
            var m = grid.Length;
            var n = grid[0].Length;
            var tmp = new int[m * n];
            var result = 0;

            for (var i = 0; i < m; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    if ((grid[i][j] - grid[0][0]) % x != 0)
                    {
                        return -1;
                    }

                    tmp[i * n + j] = grid[i][j];
                }
            }

            Array.Sort(tmp);


            var mid = tmp[tmp.Length / 2];

            foreach (var item in tmp)
            {
                result += Math.Abs(mid - item) / x;
            }

            return result;

            //runtime 14%
            //var tmp = grid.SelectMany(x => x).ToArray();
            //var tmp = new int[grid.Length * grid[0].Length];
            //var i = 0;

            //foreach (var m in grid)
            //{
            //    foreach (var n in m)
            //    {
            //        tmp[i++] = n;
            //    }
            //}

            //Array.Sort(tmp);

            //var mid = tmp[tmp.Length / 2];
            //var result = 0;

            //foreach (var item in tmp)
            //{
            //    if (Math.Abs(mid - item) % x != 0)
            //    {
            //        return -1;
            //    }

            //    result += Math.Abs(mid - item) / x;
            //}

            //return result;
        }
    }
}
