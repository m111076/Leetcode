using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0994_Rotting_Oranges
    {
        private List<int[]> direction = new List<int[]>
        {
            new int[]{1,0 },
            new int[]{0,1},
            new int[]{-1,0},
            new int[]{0,-1},
        };
        public int OrangesRotting(int[][] grid)
        {
            var rottenQueue = new Queue<int[]>();
            var fresh = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                        fresh++;
                    else if (grid[i][j] == 2)
                        rottenQueue.Enqueue(new int[] { i, j });
                }
            }

            var result = 0;

            while (fresh > 0 && rottenQueue.Count > 0)
            {
                result++;

                var size = rottenQueue.Count;

                for (var i = 0; i < size; i++)
                {
                    var tmp = rottenQueue.Dequeue();

                    foreach (var d in direction)
                    {
                        var tmpi = tmp[0] + d[0];
                        var tmpj = tmp[1] + d[1];

                        if (tmpi >= 0 && tmpi < grid.Length && tmpj >= 0 && tmpj < grid[0].Length && grid[tmpi][tmpj] == 1)
                        {
                            rottenQueue.Enqueue(new int[] { tmpi, tmpj });
                            grid[tmpi][tmpj] = 2;
                            fresh--;
                        }
                    }
                }
            }

            return fresh > 0 ? -1 : result;
        }
    }
}
