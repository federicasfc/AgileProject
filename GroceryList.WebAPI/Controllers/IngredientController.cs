using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Models.Ingredient;
using GroceryList.Service.Ingredient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GroceryList.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        // field to access service methods
        private readonly IIngredientService _ingredientService;

        // contructor
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        //Post 
        [HttpPost]
        /* WORKS */
        public async Task<IActionResult> CreateIngredient([FromForm] IngredientCreate request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _ingredientService.CreateIngredientAsync(request) == false)
                return BadRequest("Ingredient could not be created."); 


            return Ok("Ingredient created successfully");
        }

        // GetAllIngredients endpoint
        [HttpGet]
        /* WORKS */
        public async Task<IActionResult> GetAllIngredients()
        {
            var ingredients = await _ingredientService.GetAllIngredientsAsync();
            return Ok(ingredients);
        }
    }
}