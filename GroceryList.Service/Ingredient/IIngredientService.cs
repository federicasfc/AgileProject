using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Models.Ingredient;

namespace GroceryList.Service.Ingredient
{
    public interface IIngredientService
    {
        Task<bool> CreateIngredientAsync(IngredientCreate request);
        Task<IEnumerable<IngredientListItem>> GetAllIngredientsAsync();
        

    }
}