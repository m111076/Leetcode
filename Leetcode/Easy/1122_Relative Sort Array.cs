using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1122_Relative_Sort_Array
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            //runtime 23%
            //runtime 100%
            //判斷和運算合併可以提速
            //while那邊
            var tmp = new int[1001];
            var result = new int[arr1.Length];
            var index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                tmp[arr1[i]]++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                while (tmp[arr2[i]]-- > 0)
                {
                    result[index++] = arr2[i];
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                while (tmp[i]-- > 0)
                {
                    result[index++] = i;
                }
            }

            return result;

        }
    }
}
