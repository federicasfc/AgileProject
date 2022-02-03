using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<RecipeEntity> Recipes { get; set; }

        public DbSet<RecipeIngredientJTEntity> RecipeIngredients { get; set; }

        public DbSet<IngredientEntity> Ingredients { get; set; }



    }
}
