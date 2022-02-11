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
                FoodCategory = request.FoodCategory,
            };

            _dbContext.Ingredients.Add(ingredientEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        } //when enums are entered into the postman body, their numerical values have to be added

        // GetAllIngredients method
        public async Task<IEnumerable<IngredientListItem>> GetAllIngredientsAsync()
        {
            var ingredients = await _dbContext.Ingredients
                .Select(entity => new IngredientListItem
                {
                    IngredientId = entity.IngredientId,
                    Name = entity.Name
                }).ToListAsync();
            return ingredients;
        }
    }
}