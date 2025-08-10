using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0869_Reordered_Power_of_2
    {
        public bool ReorderedPowerOf2(int n)
        {
            var target = GetDigits(n);

            for (var i = 0; i < 32; i++)
            {
                if (IsEqual(target, GetDigits(1 << i)))
                    return true;
            }

            return false;
        }

        private bool IsEqual(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        private int[] GetDigits(int n)
        {
            var digits = new int[10];
            while (n > 0)
            {
                digits[n % 10]++;
                n /= 10;
            }

            return digits;
        }

    }
}
