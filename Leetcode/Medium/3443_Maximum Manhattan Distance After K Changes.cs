using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3443_Maximum_Manhattan_Distance_After_K_Changes
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //前綴和?
        public int MaxDistance(string s, int k)
        {
            var result = 0;

            var N = 0;
            var E = 0;

            var W = 0;
            var S = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'N')
                    N++;
                else if (s[i] == 'E')
                    E++;
                else if (s[i] == 'W')
                    W++;
                else if (s[i] == 'S')
                    S++;

                result = Math.Max(result, Math.Abs(N - S) + Math.Abs(E - W) + Math.Min(k, Math.Min(N, S) + Math.Min(E, W)) * 2);
            }

            return result;
        }
    }
}
