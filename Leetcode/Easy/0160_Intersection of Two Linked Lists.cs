using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0160_Intersection_of_Two_Linked_Lists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            //runtime 84%
            //time complexity O(n)
            //space complexity O(1)
            //var tmpA = headA;
            //var tmpB = headB;

            //while (tmpA != tmpB)
            //{
            //    tmpA = tmpA == null ? headB : tmpA.next;
            //    tmpB = tmpB == null ? headA : tmpB.next;
            //}

            //return tmpA;

            //runtime 37%
            //time complexity O(a+b)
            //space complexity O(a)
            var set = new HashSet<ListNode>();
            var tmp = headA;

            while (tmp != null)
            {
                set.Add(tmp);
                tmp = tmp.next;
            }

            tmp = headB;

            while (tmp != null)
            {
                if (set.Contains(tmp))
                    return tmp;
                tmp = tmp.next;
            }

            return null;
        }
    }
}
