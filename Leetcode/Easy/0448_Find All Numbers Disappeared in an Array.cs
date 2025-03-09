using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0448_Find_All_Numbers_Disappeared_in_an_Array
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            //runtime 97%
            var result = new List<int>();
            var numExist = new bool[nums.Length + 1];

            foreach (var num in nums)
            {
                numExist[num] = true;
            }

            for (var i = 1; i <= nums.Length; i++)
            {
                if (numExist[i] == false)
                    result.Add(i);
            }

            return result;

            ////runtime 56%
            //var numDic = new Dictionary<int, int>();
            //var result = new List<int>();

            //foreach (var num in nums)
            //{
            //    if (!numDic.ContainsKey(num))
            //    {
            //        numDic.Add(num, num);
            //    }
            //}

            //for (var i = 1; i <= nums.Length; i++)
            //{
            //    if (!numDic.ContainsKey(i))
            //        result.Add(i);
            //}
            //return result;
        }
    }
}
