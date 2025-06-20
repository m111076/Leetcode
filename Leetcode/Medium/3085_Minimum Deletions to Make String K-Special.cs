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
            var fregs = dic.Values.ToArray();
            Array.Sort(fregs);

            foreach (var freg in fregs)
            {
                var deleteCnt = 0;
                foreach (var f in fregs)
                {
                    if (f < freg)
                        deleteCnt += f;
                    else if (f > freg + k)
                        deleteCnt += f - freg - k;
                }
                result = Math.Min(result, deleteCnt);
            }

            return result;
        }
    }
}
