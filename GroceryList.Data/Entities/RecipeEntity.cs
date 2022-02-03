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
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]

        public string Steps { get; set; }

        public int CookTimeInMinutes { get; set; }

        [Required]

        public List<RecipeIngredientJTEntity> Ingredients { get; set; }



    }
}