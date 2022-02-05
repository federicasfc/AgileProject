using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Models.Recipe;
using GroceryList.Service.Recipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GroceryList.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        //Will contain Http endpoint methods connecting to Service methods

        //Field connecting to Service interface to have access to Service methods
        private readonly IRecipeService _recipeService;

        //Constructor

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        //Post Method connects to CreateRecipeMethod

        [HttpPost]

        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCreate request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _recipeService.CreateRecipeAsync(request) == false)
                return BadRequest("Recipe could not be created");

            return Ok("Recipe created successfully");
        } //does not work //Bad request 400- has to do with a syntax error on how to add enum values in postman probably

        //For reference. This is what I added into the Postman body in raw Json:
        /*
        {
             "Name": "Peanut Butter and Jelly Sandwich",
            "Steps": "1. Get bread, PB, and Jelly, 2. Spread PB and Jelly on bread",
             "Ingredients": 
            [
                {
                     "Name":"Peanut Butter",
                     "FoodCategory": "Carb"

                },
                 {
                     "Name": "Jelly",
                     "FoodCategory": "Fruit"
                 },
                {
                     "Name": "Bread",
                     "FoodCategory": "Carb"
                }
            ]
        }
        */


        //GetAllRecipes

        [HttpGet]

        public async Task<IActionResult> GetAllRecipes()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();
            return Ok(recipes);
        } //works

        //GetRecipesByName

        [HttpGet("{recipeName}")]

        public async Task<IActionResult> GetRecipeByName([FromRoute] string recipeName)
        {
            var detail = await _recipeService.GetRecipeByNameAsync(recipeName);

            if (detail is null)
                return NotFound();

            return Ok(detail);
        } //half works...I think; Getting a 404 NotFound back, which is exactly what is expected since there are no recipes in the Db yet
          //Unable to test the full functionality until after issue with CreateRecipe is resolved








    }
}