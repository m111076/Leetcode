using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        public int GetDecimalValue(ListNode head)
        {
            var result = 0;

            while (head != null)
            {
                result *= 2;
                result += head.val;
                head = head.next;
            }

            return result;
        }
    }
}
