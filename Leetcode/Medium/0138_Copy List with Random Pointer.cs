using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.Medium
{
    internal class _0138_Copy_List_with_Random_Pointer
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            //runtime 97%
            //time complexity O(n)
            //space complexity O(1)
            if (head == null)
                return head;

            for (var cur = head; cur != null; cur = cur.next.next)
            {
                var tmp = cur.next;
                cur.next = new Node(cur.val);
                cur.next.next = tmp;
            }

            for (var cur = head; cur != null; cur = cur.next.next)
            {
                if (cur.random != null)
                {
                    cur.next.random = cur.random.next;
                }
            }

            var result = head.next;
            var ori = head;

            for (; ori.next.next != null; ori = ori.next)
            {
                var tmp = ori.next;
                ori.next = tmp.next;
                tmp.next = tmp.next.next;
            }
            ori.next = null;

            return result;
        }

    }
}
