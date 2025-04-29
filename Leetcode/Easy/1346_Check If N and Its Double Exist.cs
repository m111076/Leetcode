using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1346_Check_If_N_and_Its_Double_Exist
    {
        public bool CheckIfExist(int[] arr)
        {
            //用hashset
            //runtime 63%
            //time complexity O(n)
            var set = new HashSet<int>();

            foreach (var item in arr)
            {
                if (set.Contains(item * 2))
                    return true;
                if ((item & 1) == 0 && set.Contains(item / 2))
                    return true;

                set.Add(item);
            }

            return false;

            //runtime 18%
            //time complexity O(n)
            var dic = new Dictionary<float, int>();

            foreach (int i in arr)
            {
                var target = (float)i * 2;
                var target2 = (float)i / 2;

                if (dic.ContainsKey(target))
                    return true;

                if (dic.ContainsKey(target2))
                    return true;

                if (!dic.ContainsKey(i))
                    dic.Add((float)i, i);
            }

            return false;
        }
    }
}
