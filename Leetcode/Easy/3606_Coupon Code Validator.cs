using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3606_Coupon_Code_Validator
    {

        private Dictionary<string, int> categoryMap = new Dictionary<string, int>
        {
            { "electronics", 0 },
            { "grocery", 1 },
            { "pharmacy", 2 },
            { "restaurant", 3 }
        };

        private List<string>[] categories = new List<string>[]
        {
            new List<string>(), // electronics
            new List<string>(), // grocery
            new List<string>(), // pharmacy
            new List<string>()  // restaurant
        };

        public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
        {
            var result = new List<string>();

            for (int i = 0; i < code.Length; i++)
            {
                if (isActive[i] && code[i] != string.Empty)
                {
                    var isDorL = code[i].All(c => Char.IsLetterOrDigit(c) || c == '_');
                    var categoriesIdx = categoryMap.GetValueOrDefault(businessLine[i], -1);
                    if (isDorL && categoriesIdx != -1)
                    {
                        categories[categoriesIdx].Add(code[i]);
                    }
                }
            }

            foreach (var category in categories)
            {
                if (category.Count > 0)
                {
                    category.Sort(StringComparer.Ordinal);
                    result.AddRange(category);
                }
            }

            return result;
        }
    }
}
