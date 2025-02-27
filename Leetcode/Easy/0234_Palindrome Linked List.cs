using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0234_Palindrome_Linked_List
    {
        //public string SlowString = string.Empty;
        //public string FastString = string.Empty;
        //runtime97%
        //直接找中點，然後後半反向
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return true;

            var faster = head;
            var slow = head;

            while (faster != null && faster.next != null)
            {
                slow = slow.next;
                faster = faster.next.next;
            }

            var current = slow;
            ListNode previous = null;

            while (current != null)
            {
                var temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            while (previous != null)
            {
                if (previous.val != head.val)
                    return false;
                previous = previous.next;
                head = head.next;
            }
            return true;
        }


        //TIme  Exceed
        //public bool IsPalindrome(ListNode head)
        //{
        //    if (head == null) return false;
        //    if (head.next == null) return true;

        //    readValue(head, head);
        //    if (FastString.Length % 2 == 0)
        //    {
        //        FastString = FastString.Substring(SlowString.Length, FastString.Length - SlowString.Length);
        //        return SlowString.SequenceEqual(FastString.Reverse());
        //    }
        //    else
        //    {
        //        FastString = FastString.Substring(SlowString.Length, FastString.Length - SlowString.Length);
        //        SlowString = SlowString.Substring(0, SlowString.Length - 1);
        //        return SlowString.SequenceEqual(FastString.Reverse());
        //    }
        //}

        //private void readValue(ListNode iHeadSlow, ListNode iHeadFast)
        //{
        //    if (iHeadFast == null) return;

        //    SlowString += $"{iHeadSlow.val}";
        //    FastString += $"{iHeadFast.val}";
        //    if (iHeadFast.next != null)
        //    {
        //        FastString += $"{iHeadFast.next.val}";
        //        readValue(iHeadSlow.next, iHeadFast.next.next);
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
