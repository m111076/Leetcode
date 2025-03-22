using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0501_Find_Mode_in_Binary_Search_Tree
    {
        //runtime 100%
        //題目中要求找出出現次數最多的數字
        //題目說root左側中出現的數字必定小於root.val
        //root右側中出現的數字必定大於root.val
        //因此這題可以透過inorder traversal來解
        //inorder traversal可以將BST的數字由小到大排列
        public int[] FindMode(TreeNode root)
        {
            var result = new List<int>();
            var maxCount = 0;
            var currentCount = 0;
            var currentVal = 0;

            InOrder(root);

            return result.ToArray();

            void InOrder(TreeNode node)
            {
                if (node == null)
                    return;

                InOrder(node.left);

                if (node.val == currentVal)
                {
                    currentCount++;
                }
                else
                {
                    currentVal = node.val;
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    result.Clear();
                    result.Add(currentVal);
                }
                else if (currentCount == maxCount)
                {
                    result.Add(currentVal);
                }

                InOrder(node.right);
            }

        }
    }
}
