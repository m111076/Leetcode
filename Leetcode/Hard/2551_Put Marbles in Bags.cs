using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    public static class _2551_Put_Marbles_in_Bags
    {
        //runtime 100%
        //不管怎麼選擇頭尾都必定會選擇到，所以頭尾的直可以忽略
        //選擇i和i+1之間插入會得到w[i]+w[i+1]的值
        //因此只要將所有空格都算過一次並排序，然後選擇最大及最小的k-1個值
        public static long PutMarbles(int[] weights, int k)
        {
            var tmp = new int[weights.Length - 1];
            long result = 0;

            for (int i = 0; i < weights.Length - 1; i++)
            {
                tmp[i] = weights[i] + weights[i + 1];
            }

            Array.Sort(tmp);

            for (var i = 0; i < k - 1; i++)
            {
                result += tmp[tmp.Length - 1 - i] - tmp[i];
            }

            return result;
        }
    }
}
