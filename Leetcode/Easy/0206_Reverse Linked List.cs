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
            //time complexity O(n)
            //space complexity O(1)
            //順序問題，紀錄好每個node接下來的位置
            ListNode pre = null;
            ListNode cur = head;

            while (cur != null)
            {
                var tmp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = tmp;
            }

            return pre;
        }
    }
}
