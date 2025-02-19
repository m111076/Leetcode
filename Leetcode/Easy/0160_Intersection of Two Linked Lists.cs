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
            // runtime 53% memory 99%
            var set = new HashSet<ListNode>();
            var targetA = headA;
            var targetB = headB;

            while (targetA != null || targetB != null)
            {
                if (targetA != null)
                {
                    if (set.Contains(targetA))
                    {
                        return targetA;
                    }
                    set.Add(targetA);
                    targetA = targetA.next;
                }
                if (targetB != null)
                {
                    if (set.Contains(targetB))
                    {
                        return targetB;
                    }
                    set.Add(targetB);
                    targetB = targetB.next;
                }
            }
            return null;

            //範例
            //Stack<ListNode> s1 = new Stack<ListNode>();
            //Stack<ListNode> s2 = new Stack<ListNode>();

            //while (headA != null)
            //{
            //    s1.Push(headA);
            //    headA = headA.next;
            //}

            //while (headB != null)
            //{
            //    s2.Push(headB);
            //    headB = headB.next;
            //}

            //ListNode ans = null;
            //while ((s1.Count > 0 && s2.Count > 0) && (s1.Peek() == s2.Peek()))
            //{
            //    ans = s1.Pop();
            //    s2.Pop();
            //}

            //return ans;


            // runtime 50% memory 6%
            //var setA = new HashSet<ListNode>();
            //var setB = new HashSet<ListNode>();

            //var targetA = headA;
            //var targetB = headB;

            //while (targetA != null || targetB != null)
            //{
            //    if (targetA != null)
            //    {
            //        if (setB.Contains(targetA))
            //        {
            //            return targetA;
            //        }
            //        setA.Add(targetA);
            //        targetA = targetA.next;
            //    }
            //    if (targetB != null)
            //    {
            //        if (setA.Contains(targetB))
            //        {
            //            return targetB;
            //        }
            //        setB.Add(targetB);
            //        targetB = targetB.next;
            //    }
            //}

            //return null;

        }
    }
}
