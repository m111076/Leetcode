using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _1079_Letter_Tile_Possibilities
    {
        public static int NumTilePossibilities(string tiles)
        {
            var freq = new int[26];
            foreach (var tile in tiles)
            {
                freq[tile - 'A']++;
            }
            return dfs(freq);

            int dfs(int[] freq) 
            {
                int count = 0;
                for (int i = 0; i < freq.Length; i++)
                {
                    if (freq[i] > 0)
                    {
                        freq[i]--;
                        count += dfs(freq) + 1;
                        freq[i]++;
                    }
                }
                return count;
            }

        }
    }
}
