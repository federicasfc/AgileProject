using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Models.Recipe;

namespace GroceryList.Service.Recipe
{
    public interface IRecipeService
    {
        Task<bool> CreateRecipeAsync(RecipeCreate request);
    }
}