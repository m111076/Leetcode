using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1323_Maximum_69_Number
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public int Maximum69Number(int num)
        {
            var result = new StringBuilder(num.ToString());
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] == '6')
                {
                    result[i] = '9';
                    break;
                }
            }

            return int.Parse(result.ToString());
        }
    }
}
