using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0521_Longest_Uncommon_Subsequence_I
    {
        //runtime 100%
        //這題?????
        public int FindLUSlength(string a, string b)
        {
            return a == b ? -1 : Math.Max(a.Length, b.Length);
        }
    }
}
