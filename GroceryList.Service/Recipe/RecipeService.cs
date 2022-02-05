using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using GroceryList.Data.Entities;
using GroceryList.Models.Recipe;
using Microsoft.EntityFrameworkCore;

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
                Ingredients = request.Ingredients
            };

            _dbContext.Recipes.Add(recipeEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        //GetAllRecipes

        public async Task<IEnumerable<RecipeListItem>> GetAllRecipesAsync()
        {
            var recipes = await _dbContext.Recipes
            .Select(entity => new RecipeListItem
            {
                Id = entity.Id,
                Name = entity.Name
            }).ToListAsync();

            return recipes;
        }

        //GetRecipeByName

        public async Task<RecipeDetail> GetRecipeByNameAsync(string recipeName)
        {
            var recipeEntity = await _dbContext.Recipes.Include(e => e.Ingredients) //might have to add foreign key to tables? thought that was done already but alas
            .FirstOrDefaultAsync(e => e.Name == recipeName);

            return recipeEntity is null ? null : new RecipeDetail
            {
                Id = recipeEntity.Id,
                Name = recipeEntity.Name,
                Description = recipeEntity.Description,
                Steps = recipeEntity.Steps,
                CookTimeInMinutes = recipeEntity.CookTimeInMinutes,
                Ingredients = recipeEntity.Ingredients.ToList() //Genuinely not sure if this works the way I want it to, but it cleared by error of "cannot convert type"
            };

        }
    }
}