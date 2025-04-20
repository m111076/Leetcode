using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1282_Group_the_People_Given_the_Group_Size_They_Belong_To
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var result = new List<IList<int>>();
            var tmpDic = new Dictionary<int, List<int>>();

            for(var i=0; i < groupSizes.Length; i++)
            {
                var group = groupSizes[i];
                if(tmpDic.TryGetValue(group, out var list))
                {
                    list.Add(i);
                }
                else
                {
                    tmpDic[group] = new List<int> { i };
                }
                if (tmpDic[group].Count == group)
                {
                    result.Add(tmpDic[group]);
                    tmpDic.Remove(group);
                }
            }

            return result;
        }
    }
}
