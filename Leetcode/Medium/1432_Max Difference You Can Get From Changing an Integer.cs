using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1432_Max_Difference_You_Can_Get_From_Changing_an_Integer
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //最大:只要頭不是9就改成9
        //最小:，因為題目說頭不能為0，所以須先判斷頭是不是1，如果投不是1則值將其改為1，若是1則將後續不是0或1的改為0
        public int MaxDiff(int num)
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

            for (var i = 0; i < numStr.Length; i++)
            {
                if (i == 0)
                {
                    if (numStr[i] != '1')
                    {
                        var minStr = numStr.Replace(numStr[i], '1');
                        min = int.Parse(minStr);
                        break;
                    }
                }
                else if (i > 0 && numStr[i] != '0' && numStr[i] != '1')
                {
                    var minStr = numStr.Replace(numStr[i], '0');
                    min = int.Parse(minStr);
                    break;
                }

            }
            return max - min;
        }
    }
}
