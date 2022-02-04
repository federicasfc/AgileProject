﻿// <auto-generated />
using GroceryList.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryList.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220204220019_AddedFKRships")]
    partial class AddedFKRships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryList.Data.Entities.IngredientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Allergens")
                        .HasColumnType("int");

                    b.Property<int>("FoodCategory")
                        .HasColumnType("int");

                    b.Property<bool>("IsAnimalProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCarb")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("GroceryList.Data.Entities.RecipeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CookTimeInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Steps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("IngredientEntityRecipeEntity", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientEntityRecipeEntity");
                });

            modelBuilder.Entity("IngredientEntityRecipeEntity", b =>
                {
                    b.HasOne("GroceryList.Data.Entities.IngredientEntity", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryList.Data.Entities.RecipeEntity", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
