using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2566_Maximum_Difference_by_Remapping_a_Digit
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public int MinMaxDifference(int num)
        {
            var numStr = num.ToString();
            var max = num;
            var min = num;

            foreach (var c in numStr)
            {
                if (c != '9')
                {
                    var maxStr = numStr.Replace(c, '9');
                    max = int.Parse(maxStr);
                    break;
                }
            }

            min = int.Parse(numStr.Replace(numStr[0], '0'));

            return max - min;
        }
    }
}
