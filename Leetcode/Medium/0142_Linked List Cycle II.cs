using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0142_Linked_List_Cycle_II
    {
        public ListNode DetectCycle(ListNode head)
        {
            //runtime 84%
            //time complexity O(n)
            //space complexity O(1)
            if (head == null || head.next == null)
                return null;

            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    break;
            }

            if (slow != fast)
                return null;

            slow = head;

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}
