using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryList.Models.Ingredient
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
    public class IngredientDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public Allergens Allergens { get; set; }
        public bool IsAnimalProduct { get; set; }
        public bool IsCarb { get; set; }
    }
}