using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0141_Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            //runtime 78%
            //time complexity O(n)
            //space complexity O(1)
            if (head == null || head.next == null)
                return false;

            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;


            //runtime 52%
            //time complexity O(n)
            //space complexity O(n)
            //var set = new HashSet<ListNode>();
            //while (head != null)
            //{
            //    if (set.Contains(head))
            //        return true;

            //    set.Add(head);
            //    head = head.next;
            //}

            //return false;
        }
    }
}
