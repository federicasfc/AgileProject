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
        }


    }
}