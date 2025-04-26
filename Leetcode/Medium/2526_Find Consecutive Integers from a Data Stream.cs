using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2526_Find_Consecutive_Integers_from_a_Data_Stream
    {
        //runtime 100%
        public class DataStream
        {
            private int amount;
            private int target;
            private int count;

            public DataStream(int value, int k)
            {
                amount = k;
                target = value;
            }

            public bool Consec(int num)
            {
                if(num == target)
                {
                    count++;
                    if (count >= amount)
                        return true;
                }
                else
                {
                    count = 0;
                }
                return false;
            }
        }

        //runtime 0%
        //public class DataStream
        //{
        //    private int amount;
        //    private int target;
        //    private Queue<int> container;
        //    private Dictionary<int, int> dict;

        //    public DataStream(int value, int k)
        //    {
        //        amount = k;
        //        target = value;
        //        container = new Queue<int>();
        //        dict = new Dictionary<int, int>();
        //    }

        //    public bool Consec(int num)
        //    {
        //        if (container == null)
        //            return false;

        //        if (container.Count == amount)
        //        {
        //            var tmp = container.Dequeue();
        //            dict[tmp]--;
        //            if (dict[tmp] == 0)
        //                dict.Remove(tmp);

        //            container.Enqueue(num);

        //            if (dict.ContainsKey(num))
        //                dict[num]++;
        //            else
        //                dict.Add(num, 1);

        //            if (dict.Count == 1 && dict.ContainsKey(target))
        //                return true;
        //        }
        //        else
        //        {
        //            container.Enqueue(num);

        //            if (dict.ContainsKey(num))
        //                dict[num]++;
        //            else
        //                dict.Add(num, 1);

        //            if (container.Count == amount && dict.Count == 1 && dict.ContainsKey(target))
        //                return true;
        //        }

        //        return false;
        //    }
        //}
    }
}
