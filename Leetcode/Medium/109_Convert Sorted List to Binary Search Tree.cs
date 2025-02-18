using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _109_Convert_Sorted_List_to_Binary_Search_Tree
    {
        public static TreeNode SortedListToBST(ListNode head)
        {
            return Helper(head, null);
        }

        public static TreeNode Helper(ListNode iHead, ListNode iTail)
        {
            if (iHead == iTail)
                return null;

            var farNode = iHead;
            var nearNode = iHead;
            while (farNode != iTail && farNode.next != iTail)
            {
                nearNode = nearNode.next;
                farNode = farNode.next.next;
            }
            var node = new TreeNode(nearNode.val);
            node.left = Helper(iHead, nearNode);
            node.right = Helper(nearNode.next, iTail);
            return node;

        }
    }
}
