using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data.Entities;

namespace GroceryList.Models.Ingredient
{
    public class IngredientCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} characters long.")]
        public string Name { get; set; }

        [Required]
        public FoodCategory FoodCategory { get; set; }
    }
}