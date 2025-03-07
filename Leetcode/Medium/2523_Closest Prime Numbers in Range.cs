using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2523_Closest_Prime_Numbers_in_Range
    {
        public static int[] ClosestPrimes(int left, int right)
        {
            //runtime 24
            var isPrime = new bool[right + 1];
            for (int i = 2; i <= right; i++)
                isPrime[i] = true;

            for (int p = 2; p * p <= right; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= right; i += p)
                        isPrime[i] = false;
                }
            }

            var primes = new List<int>();
            for (int i = 2; i <= right; i++)
            {
                if (isPrime[i])
                    if (i >= left)
                        primes.Add(i);
            }

            var oLeft = -1;
            var oRight = -1;
            var min = int.MaxValue;
            var length = primes.Count;

            if (primes.Count >= 2)
            {
                for (var i = 1; i < length; i++)
                {
                    var s = primes[i] - primes[i - 1];
                    if (s < min)
                    {
                        min = s;
                        oLeft = primes[i - 1];
                        oRight = primes[i];
                    }
                }
            }
            return new int[] { oLeft, oRight };

            //TLE
            //Sieve of Eratosthenes
            //var primeDic = new Dictionary<int, int>();
            //for (var i = 2; i <= right; i++)
            //{
            //    primeDic.Add(i, i);
            //}

            //var result = new List<int>();

            //while (primeDic.Count != 0)
            //{
            //    var target = primeDic.Min(s => s.Key);
            //    var tmp = primeDic.Where(s => (s.Key % target) == 0);
            //    if (target >= left && target <= right)
            //        result.Add(target);

            //    foreach (var t in tmp)
            //    {
            //        primeDic.Remove(t.Key);
            //    }
            //}

            //var oLeft = -1;
            //var oRight = -1;
            //var min = int.MaxValue;
            //var length = result.Count;

            //if (result.Count == 0 || result.Count == 1)
            //{

            //}
            //else
            //{
            //    for (var i = 1; i < length; i++)
            //    {
            //        var s = result[i] - result[i - 1];
            //        if (s < min)
            //        {
            //            min = s;
            //            oLeft = result[i - 1];
            //            oRight = result[i];
            //        }
            //    }
            //}
            //return new int[] { oLeft, oRight };
        }
    }
}
