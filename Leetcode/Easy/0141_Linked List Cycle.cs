using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0141_Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            //Hash超快
            var passNode = new HashSet<ListNode>();
            var targetNode = head;

            while (targetNode != null)
            {
                if (passNode.Contains(targetNode))
                    return true;
                passNode.Add(targetNode);
                targetNode = targetNode.next;
            }
            return false;

            //Runtime 8% Memory 5%  = = 
            //var passNodeDic = new Dictionary<ListNode, int>();
            //var targetNode = head;

            //while (targetNode != null)
            //{
            //    if (passNodeDic.ContainsKey(targetNode))
            //        return true;
            //    passNodeDic.Add(targetNode, 1);
            //    targetNode = targetNode.next;
            //}
            //return false;
        }
    }
}
