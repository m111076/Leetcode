using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2410_Maximum_Matching_of_Players_With_Trainers
    {
        //runtime 81%
        //time complexity O(nlogn)
        //space complexity O(1)
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);
            var idx = 0;
            var result = 0;

            foreach (var player in players)
            {
                while (idx < trainers.Length && trainers[idx] < player)
                {
                    idx++;
                }
                if (idx < trainers.Length)
                {
                    idx++;
                    result++;
                }
            }
            return result;
        }
    }
}
