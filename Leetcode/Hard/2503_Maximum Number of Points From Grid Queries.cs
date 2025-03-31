using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    public class _2503_Maximum_Number_of_Points_From_Grid_Queries
    {
        public int[] MaxPoints(int[][] grid, int[] queries)
        {
            var directions = new int[][]
            {
                new int[] { 0, -1 },
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { -1, 0 },
            };

            var m = grid.Length;
            var n = grid[0].Length;
            var answer = new int[queries.Length];
            var tmpQueries = queries.Select((value, idx) => (value, idx)).OrderBy(x => x.value).ToArray();
            //var visited = new HashSet<int>();
            var visited = new bool[m, n];
            var current = new Queue<int>();
            var next = new Queue<int>();
            var cnt = 0;
            current.Enqueue(0);

            foreach (var tmp in tmpQueries)
            {
                while (current.Count > 0)
                {
                    var idx = current.Dequeue();

                    //if (visited.Contains(idx))
                    if (visited[idx / n, idx % n])
                        continue;

                    //visited.Add(idx);


                    if (tmp.value > grid[idx / n][idx % n])
                    {
                        visited[0, 0] = true;
                        cnt++;
                        foreach (var direction in directions)
                        {
                            var row = idx / n + direction[0];
                            var col = idx % n + direction[1];

                            if (row >= 0 && row < m && col >= 0 && col < n)
                                current.Enqueue(row * n + col);
                        }
                    }
                    else
                    {
                        next.Enqueue(idx);
                    }
                }

                answer[tmp.idx] = cnt;

                while (next.Count > 0)
                {
                    var t = next.Dequeue();
                    //visited.Remove(t);
                    current.Enqueue(t);
                }

            }
            return answer;
        }
    }
}
