using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryList.Data.Migrations
{
    public partial class FixedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Ingredients_IngredientsId",
                table: "IngredientEntityRecipeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Recipes_RecipesId",
                table: "IngredientEntityRecipeEntity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recipes",
                newName: "RecipeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ingredients",
                newName: "IngredientId");

            migrationBuilder.RenameColumn(
                name: "RecipesId",
                table: "IngredientEntityRecipeEntity",
                newName: "RecipesRecipeId");

            migrationBuilder.RenameColumn(
                name: "IngredientsId",
                table: "IngredientEntityRecipeEntity",
                newName: "IngredientsIngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientEntityRecipeEntity_RecipesId",
                table: "IngredientEntityRecipeEntity",
                newName: "IX_IngredientEntityRecipeEntity_RecipesRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Ingredients_IngredientsIngredientId",
                table: "IngredientEntityRecipeEntity",
                column: "IngredientsIngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Recipes_RecipesRecipeId",
                table: "IngredientEntityRecipeEntity",
                column: "RecipesRecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Ingredients_IngredientsIngredientId",
                table: "IngredientEntityRecipeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Recipes_RecipesRecipeId",
                table: "IngredientEntityRecipeEntity");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Recipes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "Ingredients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RecipesRecipeId",
                table: "IngredientEntityRecipeEntity",
                newName: "RecipesId");

            migrationBuilder.RenameColumn(
                name: "IngredientsIngredientId",
                table: "IngredientEntityRecipeEntity",
                newName: "IngredientsId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientEntityRecipeEntity_RecipesRecipeId",
                table: "IngredientEntityRecipeEntity",
                newName: "IX_IngredientEntityRecipeEntity_RecipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Ingredients_IngredientsId",
                table: "IngredientEntityRecipeEntity",
                column: "IngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientEntityRecipeEntity_Recipes_RecipesId",
                table: "IngredientEntityRecipeEntity",
                column: "RecipesId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
