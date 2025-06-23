using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0234_Palindrome_Linked_List
    {
        public bool IsPalindrome(ListNode head)
        {
            //runtime 97%
            //time complexity O(n)
            //space complexity O(1)
            if (head.next == null)
                return true;

            var slow = head;
            var fast = head;
            ListNode pre = null;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                var tmp = slow.next;
                slow.next = pre;
                pre = slow;
                slow = tmp;
            }

            if (fast != null)
            {
                slow = slow.next;
            }

            while (pre != null && slow != null)
            {
                if (pre.val != slow.val)
                    return false;
                pre = pre.next;
                slow = slow.next;
            }

            return true;
        }
    }
}
