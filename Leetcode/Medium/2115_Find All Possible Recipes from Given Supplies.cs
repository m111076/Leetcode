using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2115_Find_All_Possible_Recipes_from_Given_Supplies
    {
        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            var supHashSet = new HashSet<string>(supplies);
            var recipesIngredients = new Dictionary<string, List<string>>();
            var recipeCanMake = new Dictionary<string, int>();
            var result = new List<string>();

            for (int i = 0; i < recipes.Length; i++)
            {
                recipesIngredients.Add(recipes[i], ingredients[i].ToList());
            }

            foreach (var recipe in recipes)
            {
                Check(recipe);
            }


            return result;


            bool Check(string iRecipe)
            {
                if (recipeCanMake.ContainsKey(iRecipe))
                {
                    return recipeCanMake[iRecipe] == 1;
                }

                if (supHashSet.Contains(iRecipe))
                    return true;

                if (!recipesIngredients.ContainsKey(iRecipe))
                    return false;

                recipeCanMake[iRecipe] = 0;

                foreach (var ingredient in recipesIngredients[iRecipe])
                {
                    if (!Check(ingredient))
                    {
                        recipeCanMake[iRecipe] = -1;
                        return false;
                    }
                }

                recipeCanMake[iRecipe] = 1;
                result.Add(iRecipe);
                return true;
            }
        }
    }
}
