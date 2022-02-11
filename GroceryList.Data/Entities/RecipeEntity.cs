using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryList.Data.Entities
{
    public class RecipeEntity
    {
        [Key]
        public int RecipeId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]

        public string Steps { get; set; }

        public int CookTimeInMinutes { get; set; }

        //FK 


        public ICollection<IngredientEntity> Ingredients { get; set; }



    }
}