using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data.Entities;

namespace GroceryList.Models.Recipe
{
    public class RecipeCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} characters long.")]
        public string Name { get; set; }

        [Required]
        [MaxLength(9000, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Steps { get; set; }

    }
}