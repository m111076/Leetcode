using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1261_Find_Elements_in_a_Contaminated_Binary_Tree
    {
        public static HashSet<int> nodeValues = new HashSet<int>();

        public _1261_Find_Elements_in_a_Contaminated_Binary_Tree(TreeNode root)
        {
            //不需要重建TreeNode
            //recovers(root, 0);

            //void recovers(TreeNode iRoot, int iValue)
            //{
            //    if (iRoot == null) return;

            //    iRoot.val = iValue;
            //    nodeValues.Add(iValue);
            //    recovers(iRoot.left, iValue * 2 + 1);
            //    recovers(iRoot.right, iValue * 2 + 2);
            //}

            //runtime 27% memory 50%
            root.val = 0;
            nodeValues.Add(root.val);
            recovers(ref root);

            void recovers(ref TreeNode iRoot)
            {

                if (iRoot.left != null)
                {
                    iRoot.left.val = iRoot.val * 2 + 1;
                    nodeValues.Add(iRoot.left.val);
                    recovers(ref iRoot.left);
                }
                if (iRoot.right != null)
                {
                    iRoot.right.val = iRoot.val * 2 + 2;
                    nodeValues.Add(iRoot.right.val);
                    recovers(ref iRoot.right);
                }
                return;
            }
        }



        public static bool Find(int target)
        {
            return nodeValues.Contains(target);
        }
    }
}
