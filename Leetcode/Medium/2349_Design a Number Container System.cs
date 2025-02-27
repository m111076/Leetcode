using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2349_Design_a_Number_Container_System
    {
        //runtime 87%
        //原本PriorityQueue部分是用dictionory
        //但是會超時
        private Dictionary<int, PriorityQueue<int, int>> ValueIndexesDic;
        private Dictionary<int, int> IndexValueDic;

        public _2349_Design_a_Number_Container_System()
        {
            ValueIndexesDic = new Dictionary<int, PriorityQueue<int, int>>();
            IndexValueDic = new Dictionary<int, int>();
        }

        public void Change(int index, int number)
        {
            if (IndexValueDic.ContainsKey(index))
                IndexValueDic[index] = number;
            else
                IndexValueDic.Add(index, number);

            if (ValueIndexesDic.ContainsKey(number))
            {
                ValueIndexesDic[number].Enqueue(index, index);
            }
            else
            {
                var temp = new PriorityQueue<int, int>();
                temp.Enqueue(index, index);
                ValueIndexesDic.Add(number, temp);
            }
        }

        public int Find(int number)
        {
            if (ValueIndexesDic.ContainsKey(number))
            {
                while (ValueIndexesDic[number].Count > 0)
                {
                    var idx = ValueIndexesDic[number].Peek();
                    if (IndexValueDic[idx] == number) return idx;
                    else
                        ValueIndexesDic[number].Dequeue();
                }
            }

            return -1;
        }
    }
}
