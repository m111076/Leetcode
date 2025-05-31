using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0513_Find_Bottom_Left_Tree_Value
    {
        //runtime 75%
        //time complexity O(n)
        //space complexity O(1)
        //使用BFS
        //在遍歷時我們可以先將右節點放入queue，這樣可以確保最後出來時一定是最左邊的節點
        public int FindBottomLeftValue(TreeNode root)
        {
            var tmpQ = new Queue<TreeNode>();
            tmpQ.Enqueue(root);
            var targetNode = root;

            while (tmpQ.Count > 0)
            {
                targetNode = tmpQ.Dequeue();
                if (targetNode.right != null)
                    tmpQ.Enqueue(targetNode.right);
                if (targetNode.left != null)
                    tmpQ.Enqueue(targetNode.left);
            }

            return targetNode.val;
        }
    }
}
