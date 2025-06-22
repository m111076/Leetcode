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
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var result = new ListNode();
            var tmp = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tmp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tmp.next = list2;
                    list2 = list2.next;
                }

                tmp = tmp.next;
            }

            tmp.next = list1 ?? list2;

            return result.next;
        }

    }
}
