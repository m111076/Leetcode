using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0203_Remove_Linked_List_Elements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            //runtime 100%
            Check(ref head);

            return head;

            void Check(ref ListNode iHead)
            {
                if (iHead == null)
                    return;

                if (iHead.val == val)
                {
                    iHead = iHead.next;
                    Check(ref iHead);
                }
                else
                {
                    Check(ref iHead.next);
                }
            }
            //別人的 紀錄一下
            //if (head == null) return null;
            //head.next = RemoveElements(head.next, val);
            //return head.val == val ? head.next : head;
        }
    }
}
