using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using GroceryList.Data.Entities;
using GroceryList.Models.Ingredient;
using Microsoft.EntityFrameworkCore;

namespace GroceryList.Service.Ingredient
{
    public class IngredientService : IIngredientService
    {
        private readonly ApplicationDbContext _dbContext;

        //Constructor
        public IngredientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        /* CRUD */

        // CreateIngredient method
        public async Task<bool> CreateIngredientAsync(IngredientCreate request)
        {

            var ingredientEntity = new IngredientEntity
            {
                Name = request.Name,
                FoodCategory = (FoodCategory)Enum.Parse(typeof(FoodCategory), request.FoodCategory)
                // line above worked as "FoodCategory = request.FoodCategory" multiple times before and immediately after merge
                // then started throwing an error as I was working on something else saying "cannot implicitly convert type"
                // tried parsing into an enum assuming that it was receiving a string, couldn't get it to work
            };

            _dbContext.Ingredients.Add(ingredientEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        // GetAllIngredients method
        public async Task<IEnumerable<IngredientListItem>> GetAllIngredientsAsync()
        {
            var ingredients = await _dbContext.Ingredients
                .Select(entity => new IngredientListItem
                {
                    Id = entity.Id,
                    Name = entity.Name
                }).ToListAsync();
            return ingredients;
        }

        // GetIngredientByName method
        public async Task<IngredientDetail> GetIngredientByNameAsync(string ingredientName)
        {
            var ingredientEntity = await _dbContext.Ingredients
                .FirstOrDefaultAsync(e => e.Name == ingredientName);
            
            return ingredientEntity is null ? null : new IngredientDetail
            {
                Id = ingredientEntity.Id,
                Name = ingredientEntity.Name,
                FoodCategory = ingredientEntity.FoodCategory,
                Allergens = ingredientEntity.Allergens,
                // same problem as CreateIngredient method and not sure why
                IsAnimalProduct = ingredientEntity.IsAnimalProduct,
                IsCarb = ingredientEntity.IsCarb
            };
        }
    }
}