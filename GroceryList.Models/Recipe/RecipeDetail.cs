using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data.Entities;
using GroceryList.Models.Ingredient;

namespace GroceryList.Models.Recipe
{
    public class RecipeDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Steps { get; set; }

        public int CookTimeInMinutes { get; set; }

        public List<IngredientListItem> Ingredients { get; set; } //= new List<IngredientEntity>();



    }
}