using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0412_Fizz_Buzz
    {
        public IList<string> FizzBuzz(int n)
        {
            //runtime 92%
            var result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    continue;
                }
                result.Add(i.ToString());
            }
            return result;


            //runtime 18%
            //var result = new List<string>();

            //for (var i = 1; i <= n; i++)
            //{
            //    var fizz = i % 3 == 0;
            //    var buzz = i % 5 == 0;

            //    if (fizz && buzz)
            //    {
            //        result.Add("FizzBuzz");
            //        continue;
            //    }
            //    if (fizz)
            //    {
            //        result.Add("Fizz");
            //        continue;
            //    }
            //    if (buzz)
            //    {
            //        result.Add("Buzz");
            //        continue;
            //    }
            //    result.Add($"{i}");

            //}
            //return result;
        }
    }
}
