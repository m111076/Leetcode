using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //runtime 72%
    //time complexity O(n)
    internal class _1128_Number_of_Equivalent_Domino_Pairs
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var dic = new Dictionary<int, int>();

            foreach (var domino in dominoes)
            {
                var target = Math.Min(domino[0], domino[1]) * 10 + Math.Max(domino[0], domino[1]);
                if (!dic.TryAdd(target, 1))
                    dic[target]++;
            }

            var result = 0;
            foreach (var s in dic)
            {
                result += s.Value * (s.Value - 1) / 2;
            }

            return result;
        }
    }
}
