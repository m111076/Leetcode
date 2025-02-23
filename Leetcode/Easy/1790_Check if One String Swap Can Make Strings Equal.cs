using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1790_Check_if_One_String_Swap_Can_Make_Strings_Equal
    {
        //runtime 100%
        public static bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2) return true;

            var length = s1.Length;
            var diffPosition = new List<int>();

            for (var i = 0; i < length; i++)
            {
                if (s1[i] != s2[i])
                    diffPosition.Add(i);



                if (diffPosition.Count > 2)
                    return false;
            }

            if (diffPosition.Count == 2)
            {
                if (s1[diffPosition[0]] == s2[diffPosition[1]] && s1[diffPosition[1]] == s2[diffPosition[0]])
                    return true;
            }

            return false;
        }
    }
}
