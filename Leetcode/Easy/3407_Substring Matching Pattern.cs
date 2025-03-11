using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3407_Substring_Matching_Pattern
    {
        public static bool HasMatch(string s, string p)
        {
            //runtime 84%
            //split分割出2個string 
            //先找出第一個ps 的idx，再用第二個ps在 idx+str1.length~s.length-1的範圍內找idx
            //如果都有找到就是有解
            var ps = p.Split('*');
            var front = s.IndexOf(ps[0]);
            var end = s.IndexOf(ps[1], front + ps[0].Length);

            if (front != -1 && end != -1)
                return true;

            return false;
        }
    }
}
