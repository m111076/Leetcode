using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _21_Merge_Two_Sorted_Lists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;

            var temp1 = list1 == null ? 51 : list1.val;
            var temp2 = list2 == null ? 51 : list2.val;

            var temp = 0;
            if (temp1 > temp2)
            {
                temp = list2.val;
                return new ListNode() { val = temp, next = MergeTwoLists(list1, list2?.next) };
            }
            else
            {
                temp = list1.val;
                return new ListNode() { val = temp, next = MergeTwoLists(list1?.next, list2) };
            }

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
