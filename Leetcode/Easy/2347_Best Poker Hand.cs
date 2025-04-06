using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2347_Best_Poker_Hand
    {
        //runtiem 30%
        public string BestHand(int[] ranks, char[] suits)
        {
            if (suits.Distinct().Count() == 1)
            {
                return "Flush";
            }
            else
            {
                var count = new int[14];

                foreach (var rank in ranks)
                {
                    count[rank]++;
                }

                var max = count.Max();

                if (max >= 3)
                {
                    return "Three of a Kind";
                }
                else if (max == 2)
                {
                    return "Pair";
                }
                else
                {
                    return "High Card";
                }
            }
        }
    }
}
