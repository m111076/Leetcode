using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0909_Snakes_and_Ladders
    {
        //runtime 78%
        //time complexity O(n*n)
        //space complexity O(n*n)
        //BFS，但需要座標轉換
        public int SnakesAndLadders(int[][] board)
        {
            var n = board.Length;
            var visited = new bool[n * n + 1];
            var stepQueue = new Queue<(int position, int step)>();

            visited[1] = true;
            stepQueue.Enqueue((1, 0));

            while (stepQueue.Count > 0)
            {
                var cur = stepQueue.Dequeue();

                if (cur.position == n * n)
                    return cur.step;

                for (var i = 1; i <= 6; i++)
                {
                    var next = cur.position + i;

                    if (next > n * n)
                        continue;

                    var (r, c) = Position2RowCol(next, n);

                    if (board[r][c] != -1)
                        next = board[r][c];

                    if (!visited[next])
                    {
                        visited[next] = true;
                        stepQueue.Enqueue((next, cur.step + 1));
                    }
                }
            }

            return -1;
        }

        public (int R, int C) Position2RowCol(int iPosition, int iN)
        {
            iPosition -= 1;
            var isReverse = ((iPosition / iN) & 1) != 0;
            var Row = iN - (iPosition / iN) - 1;
            var Col = isReverse ? iN - 1 - iPosition % iN : iPosition % iN;

            return (Row, Col);
        }
    }
}
