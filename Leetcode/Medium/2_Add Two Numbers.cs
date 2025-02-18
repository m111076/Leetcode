using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2_Add_Two_Numbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0)
                return null;

            var Carry = 0;
            var f = l1 != null ? l1.val : 0;
            var s = l2 != null ? l2.val : 0;
            var num = f + s + carry;
            if (num > 9)
            {
                Carry = 1;
                num = num % 10;
            }
            return new ListNode() { val = num, next = AddTwoNumbers(l1?.next, l2?.next, Carry) };
        }
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
