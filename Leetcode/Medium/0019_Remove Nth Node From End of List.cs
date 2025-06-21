using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0019_Remove_Nth_Node_From_End_of_List
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //按照題目做就好了，感覺不是medium
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var cnt = 0;
            var tmp = head;

            while (tmp != null)
            {
                cnt++;
                tmp = tmp.next;
            }

            if (cnt == n)
                return head.next;

            cnt -= n;
            tmp = head;

            while (cnt - 1 > 0)
            {
                cnt--;
                tmp = tmp.next;
            }

            tmp.next = tmp.next.next;

            return head;
        }
    }
}
