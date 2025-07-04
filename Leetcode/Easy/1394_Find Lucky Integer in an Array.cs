using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1394_Find_Lucky_Integer_in_an_Array
    {
        public int FindLucky(int[] arr)
        {
            var cnt = new int[501];

            foreach (var item in arr)
            {
                cnt[item]++;
            }

            var result = -1;

            for (var i = 500; i >= 1; i--)
            {
                if (i == cnt[i])
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
