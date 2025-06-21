using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3085_Minimum_Deletions_to_Make_String_K_Special
    {
        public int MinimumDeletions(string word, int k)
        {
            var dic = new Dictionary<char, int>();

            foreach (char c in word)
            {
                dic[c] = dic.GetValueOrDefault(c, 0) + 1;
            }

            var result = int.MaxValue;
            var freqs = dic.Values.ToArray();
            Array.Sort(freqs);
            var currentF = 0;

            foreach (var freq in freqs)
            {
                if(currentF!=freq)
                    currentF = freq;
                else
                    continue;
                var deleteCnt = 0;
                foreach (var f in freqs)
                {
                    if (f < freq)
                        deleteCnt += f;
                    else if (f > freq + k)
                        deleteCnt += f - freq - k;
                }
                result = Math.Min(result, deleteCnt);
            }

            return result;
        }
    }
}
