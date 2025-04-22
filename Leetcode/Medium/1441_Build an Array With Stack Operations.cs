using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1441_Build_an_Array_With_Stack_Operations
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //每讀取一個數字都先push進去，然後判斷是否要pop出來
        //最後當idx等於target.Length時，代表已經完成了
        public IList<string> BuildArray(int[] target, int n)
        {
            var result = new List<string>();
            var idx = 0;
            for (int i = 1; i <= n; i++)
            {
                result.Add("Push");
                if (target[idx] != i)
                {
                    result.Add("Pop");
                }
                else
                {
                    idx++;
                    if (idx == target.Length)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
