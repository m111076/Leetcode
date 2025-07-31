using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1356_Sort_Integers_by_The_Number_of_1_Bits
    {
        //runtime 61%
        //time complexity O(nlogn)
        //space complexity O(n)
        public int[] SortByBits(int[] arr)
        {
            var pq = new PriorityQueue<int, (int, int)>();

            foreach (var num in arr)
            {
                var cnt = 0;
                var tmp = num;
                while (tmp > 0)
                {
                    cnt++;
                    tmp &= tmp - 1;
                }
                pq.Enqueue(num, (cnt, num));
            }

            var result = new int[arr.Length];
            var index = 0;
            while (pq.Count > 0)
            {
                result[index++] = pq.Dequeue();
            }

            return result;
        }
    }
}
