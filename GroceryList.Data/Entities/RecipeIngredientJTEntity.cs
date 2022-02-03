using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryList.Data.Entities
{
    public class RecipeIngredientJTEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [Required]

        public int RecipeId { get; set; }

        public int QuantityOfIngredient { get; set; }

        [Required]
        public virtual RecipeEntity Recipe { get; set; }

        [Required]
        public virtual IngredientEntity Ingredient { get; set; }

    }
}