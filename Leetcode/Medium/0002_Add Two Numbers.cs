using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2_Add_Two_Numbers
    {
        //runtime 100%
        //time complexity O(max(m, n))
        //space complexity O(max(l1,l2))
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0)
                return null;

            var tmp = carry;

            if (l1 != null)
                tmp += l1.val;
            if (l2 != null)
                tmp += l2.val;

            carry = tmp / 10;
            tmp %= 10;

            return new ListNode(tmp, AddTwoNumbers(l1?.next, l2?.next, carry));
        }
    }
}
