using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1422_Maximum_Score_After_Splitting_a_String
    {
        //runtime 100%
        //T:O(n) S:O(1)
        public int MaxScore(string s)
        {
            var result = 0;
            var zero = 0;
            var one = s.Split('1').Length - 1;

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '1')
                {
                    one--;
                }
                else
                {
                    zero++;
                }

                result = Math.Max(result, zero + one);
            }

            return result;
        }
    }
}
