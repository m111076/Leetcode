using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0744_Find_Smallest_Letter_Greater_Than_Target
    {
        //runtime 100%
        //time complexity O(logn)
        public char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (letters[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left < letters.Length ? letters[left] : letters[0];


            //var left = 0;
            //var right = letters.Length;

            //while (left < right)
            //{
            //    var mid = left + (right - left) / 2;

            //    if (letters[mid] > target)
            //        right = mid;
            //    else
            //        left = mid + 1;
            //}

            //return left < letters.Length ? letters[left] : letters[0];
        }
    }
}
