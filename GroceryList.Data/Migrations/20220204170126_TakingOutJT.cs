using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryList.Data.Migrations
{
    public partial class TakingOutJT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.RenameTable(
                name: "RecipeIngredients",
                newName: "RecipeIngredientJTEntity");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredientJTEntity",
                newName: "IX_RecipeIngredientJTEntity_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredientJTEntity",
                newName: "IX_RecipeIngredientJTEntity_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredientJTEntity",
                table: "RecipeIngredientJTEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredientJTEntity_Ingredients_IngredientId",
                table: "RecipeIngredientJTEntity",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredientJTEntity_Recipes_RecipeId",
                table: "RecipeIngredientJTEntity",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredientJTEntity_Ingredients_IngredientId",
                table: "RecipeIngredientJTEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredientJTEntity_Recipes_RecipeId",
                table: "RecipeIngredientJTEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredientJTEntity",
                table: "RecipeIngredientJTEntity");

            migrationBuilder.RenameTable(
                name: "RecipeIngredientJTEntity",
                newName: "RecipeIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredientJTEntity_RecipeId",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredientJTEntity_IngredientId",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
