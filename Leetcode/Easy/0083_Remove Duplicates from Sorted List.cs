using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _83_Remove_Duplicates_from_Sorted_List
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            var preNode = head;
            var curNode = head.next;

            while (curNode != null)
            {
                if (curNode.val == preNode.val)
                {
                    preNode.next = curNode.next;
                }
                else
                {
                    preNode = curNode;
                }

                curNode = curNode.next;
            }
            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }

}
