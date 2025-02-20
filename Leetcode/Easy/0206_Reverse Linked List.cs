using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0206_Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            //runtime 100%
            ListNode previousHead = null;
            ListNode currentHead = head;
            ListNode tempHead = null;

            while (currentHead != null)
            {
                tempHead = currentHead.next;
                currentHead.next = previousHead;
                previousHead = currentHead;
                currentHead = tempHead;
            }

            return previousHead;
        }
    }
}
