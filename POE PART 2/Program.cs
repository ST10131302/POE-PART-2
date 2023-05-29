using System;
using System.Collections.Generic;
using System.Linq;
//Pako Raseleka ST10131302 POE PART 2 
namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Recipe Application");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Display Recipe List");
                Console.WriteLine("3. Select Recipe to Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        recipeManager.EnterRecipeDetails();
                        Console.WriteLine("Recipe added successfully.");
                        break;
                    case "2":
                        recipeManager.DisplayRecipeList();
                        break;
                    case "3":
                        recipeManager.SelectAndDisplayRecipe();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

    

    
