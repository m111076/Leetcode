using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0455_Assign_Cookies
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            //runtime 12%
            //2pointer
            Array.Sort(g);
            Array.Sort(s);
            var idx = 0;

            for (var i = 0; idx < g.Length && i < s.Length; i++)
            {
                if (g[idx] <= s[i])
                    idx++;
            }

            return idx;
        }
    }
}
