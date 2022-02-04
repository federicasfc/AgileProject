using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using GroceryList.Data.Entities;
using GroceryList.Models.Recipe;

namespace GroceryList.Service.Recipe
{
    public class RecipeService : IRecipeService
    {
        //Will Contain Recipe CRUD
        //Field connecting to db info
        private readonly ApplicationDbContext _dbContext;

        //Constructor

        public RecipeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //CreateRecipe Method

        public async Task<bool> CreateRecipeAsync(RecipeCreate request)
        {
            var recipeEntity = new RecipeEntity
            {
                Name = request.Name,
                Steps = request.Steps,
                // Ingredients = request.Ingredients
            };

            _dbContext.Recipes.Add(recipeEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();

            return numberOfChanges == 1;
        }

    }
}