using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1052_Grumpy_Bookstore_Owner
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //滑動視窗
        //只有grumpy[i]==1時才紀錄
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            var nor = 0;
            var max = 0;
            var sum = 0;

            for (var i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                {
                    nor += customers[i];
                }
                else
                {
                    sum += customers[i];
                }

                if (i + 1 < minutes)
                    continue;

                max = Math.Max(max, sum);

                if (grumpy[i - minutes + 1] == 1)
                {
                    sum -= customers[i - minutes + 1];
                }
            }

            return max + nor;
        }
    }
}
