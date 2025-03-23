using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0506_Relative_Ranks
    {
        //runtime:77.85%
        public string[] FindRelativeRanks(int[] score)
        {
            var result = new string[score.Length];
            var tmp = score.Select((x, i) => new { Score = x, Index = i }).OrderByDescending(x => x.Score).ToArray();

            for (int i = 0; i < tmp.Length; i++)
            {
                var rank = i + 1;
                var index = tmp[i].Index;

                if (rank == 1)
                {
                    result[index] = "Gold Medal";
                }
                else if (rank == 2)
                {
                    result[index] = "Silver Medal";
                }
                else if (rank == 3)
                {
                    result[index] = "Bronze Medal";
                }
                else
                {
                    result[index] = rank.ToString();
                }
            }

            return result;
        }

    }
}
