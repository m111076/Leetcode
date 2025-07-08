using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0215_Kth_Largest_Element_in_an_Array
    {
        //runtime 56
        //time complexity O(nlogn)
        //sapce complexity O()
        public int FindKthLargest(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                pq.Enqueue(num, num);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            return pq.Peek();
        }
    }
}
