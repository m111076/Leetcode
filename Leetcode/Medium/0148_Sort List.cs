using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0148_Sort_List
    {
        //runtime 77%
        //time complexity O(nlogn)
        //space complexity O(1)
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var mid = CheckMid(head);
            var right = mid.next;
            mid.next = null;

            var lSort = SortList(head);
            var rSort = SortList(right);

            return Merge(lSort, rSort);
        }

        private ListNode CheckMid(ListNode head)
        {
            var slow = head;
            var fast = head;
            ListNode pre = null;

            while (fast != null && fast.next != null)
            {
                pre = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            return pre;
        }

        private ListNode Merge(ListNode head1, ListNode head2)
        {
            var result = new ListNode();
            var tmp = result;

            while (head1 != null && head2 != null)
            {
                if (head1.val >= head2.val)
                {
                    tmp.next = head2;
                    head2 = head2.next;
                }
                else
                {
                    tmp.next = head1;
                    head1 = head1.next;
                }

                tmp = tmp.next;
            }

            tmp.next = head1 ?? head2;

            return result.next;
        }
    }
}
