using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryList.Data.Entities
{
    public enum FoodCategory
    {
        Carb,
        Dairy,
        Fish,
        Fruit,
        Meat,
        Vegetable
    }
    public enum Allergens
    {
        Dairy,
        Eggs,
        Fish,
        Gluten,
        Peanuts,
        Shellfish,
        Soy,
        TreeNuts
    }
    public class IngredientEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public FoodCategory FoodCategory { get; set; }

        public Allergens Allergens { get; set; }
        public bool IsAnimalProduct { get; set; }
        public bool IsCarb { get; set; }

        //FK reference
        public ICollection<RecipeEntity> Recipes { get; set; }


    }
}