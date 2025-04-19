using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0038_Count_and_Say
    {
        //public string CountAndSay(int n)
        //{
        //    if (n == 1) return "1";

        //    var result = "1";

        //    for (var i = 1; i < n; i++)
        //    {
        //        var sb = new StringBuilder();
        //        var count = 1;
        //        for (var j = 1; j < result.Length; j++)
        //        {
        //            if (result[j] == result[j - 1])
        //            {
        //                count++;
        //            }
        //            else
        //            {
        //                sb.Append(count);
        //                sb.Append(result[j - 1]);
        //                count = 1;
        //            }
        //        }
        //        sb.Append(count);
        //        sb.Append(result[result.Length - 1]);
        //        result = sb.ToString();
        //    }
        //}
    }
}
