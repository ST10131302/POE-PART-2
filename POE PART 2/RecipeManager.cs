using RecipeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RecipeManager
{
    private List<Recipe> recipes;

    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    public void EnterRecipeDetails()
    {
        Console.Write("Enter the name of the recipe: ");
        string name = Console.ReadLine();

        Recipe recipe = new Recipe(name);
        recipe.EnterDetails();

        recipes.Add(recipe);
    }

    public void DisplayRecipeList()
    {
        Console.WriteLine("Recipe List");
        Console.WriteLine("------------");

        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
        }
        else
        {
            List<string> recipeNames = recipes.Select(r => r.Name).OrderBy(n => n).ToList();
            foreach (string name in recipeNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    public void SelectAndDisplayRecipe()
    {
        Console.Write("Enter the name of the recipe to display: ");
        string recipeName = Console.ReadLine();

        Recipe selectedRecipe = recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

        if (selectedRecipe == null)
        {
            Console.WriteLine("Recipe not found.");
        }
        else
        {
            selectedRecipe.Display();
        }
    }
}
