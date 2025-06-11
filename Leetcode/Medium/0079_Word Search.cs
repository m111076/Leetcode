using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 48.99%
    //time complexity O(bn*bm*3w)
    //space complexity O(bn*bm+w) 可以直接使用board來優化
    internal class _0079_Word_Search
    {
        private List<(int, int)> Directions = new List<(int, int)>()
        {
            (0, 1), // right
            (1, 0), // down
            (0, -1), // left
            (-1, 0) // up
        };

        private bool[,] visitBoard;

        public bool Exist(char[][] board, string word)
        {
            var c = new int[128];
            var b = new int[128];

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[0].Length; j++)
                {
                    ++b[board[i][j]];
                }
            }

            foreach (var ch in word)
            {
                if (++c[ch] > b[ch])
                    return false;
            }


            if (c[word[0]] < c[word[^1]])
                word = new string(word.Reverse().ToArray());

            visitBoard = new bool[board.Length, board[0].Length];

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[0].Length; j++)
                {
                    if (DFS(board, word, i, j, 0))
                        return true;
                }
            }

            return false;
        }

        private bool DFS(char[][] board, string word, int i, int j, int idx)
        {
            if (board[i][j] != word[idx])
                return false;

            if (idx == word.Length - 1)
                return true;

            visitBoard[i, j] = true;
            foreach (var (di, dj) in Directions)
            {
                var ni = i + di;
                var nj = j + dj;
                if (ni >= 0 && ni < board.Length && nj >= 0 && nj < board[0].Length && !visitBoard[ni, nj])
                {
                    if (DFS(board, word, ni, nj, idx + 1))
                        return true;
                }
            }
            visitBoard[i, j] = false;
            return false;
        }
    }
}
