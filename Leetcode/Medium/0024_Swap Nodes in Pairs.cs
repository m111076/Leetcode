using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0024_Swap_Nodes_in_Pairs
    {
        //runtime 
        //time complexity O(n)
        //space complexity O(1)
        public ListNode SwapPairs(ListNode head)
        {
            var dummy = new ListNode();
            dummy.next = head;
            var pre = dummy;

            while (pre.next != null && pre.next.next != null)
            {
                var f = pre.next;
                var s = pre.next.next;

                f.next = s.next;
                s.next = f;
                pre.next = s;
                pre = f;
            }

            return dummy.next;
        }
    }
}
