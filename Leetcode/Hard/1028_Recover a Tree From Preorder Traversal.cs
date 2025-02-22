using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    public class _1028_Recover_a_Tree_From_Preorder_Traversal
    {
        public static TreeNode RecoverFromPreorder(string traversal)
        {
            //RunTime 63% memory90% 40分鐘= =
            var result = new TreeNode();
            var idx = 0;
            var l = traversal.Length;

            while (idx < l)
            {
                var d = 0;
                var targetVal = 0;

                while (idx < l && traversal[idx] == '-')
                {
                    d++;
                    idx++;
                }

                while (idx < l && Char.IsDigit(traversal[idx]))
                {
                    targetVal = targetVal * 10 + (traversal[idx] - '0');
                    idx++;
                }

                insertVal(ref result, d, targetVal);
            }

            return result;

            void insertVal(ref TreeNode iRoot, int iDepth, int iValue)
            {
                if (iDepth == 0)
                {
                    iRoot.val = iValue;
                    return;
                }

                if (iDepth == 1)
                {
                    if (iRoot.left == null)
                    {
                        iRoot.left = new TreeNode();
                        insertVal(ref iRoot.left, --iDepth, iValue);
                        return;
                    }
                    else
                    {
                        iRoot.right = new TreeNode();
                        insertVal(ref iRoot.right, --iDepth, iValue);
                        return;
                    }
                }
                else
                {
                    if (iRoot.left == null)
                    {
                        iRoot.left = new TreeNode();
                        insertVal(ref iRoot.left, --iDepth, iValue);
                        return;
                    }
                    else if (iRoot.right != null)
                    {
                        insertVal(ref iRoot.right, --iDepth, iValue);
                        return;
                    }
                    else
                    {
                        insertVal(ref iRoot.left, --iDepth, iValue);
                        return;
                    }
                }
            }
        }
    }
}
