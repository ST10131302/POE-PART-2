using RecipeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Recipe
{
    public string Name { get; }
    private List<Ingredient> ingredients;
    private List<string> steps;

    public Recipe(string name)
    {
        Name = name;
        ingredients = new List<Ingredient>();
        steps = new List<string>();
    }

    public void EnterDetails()
    {
        Console.Write("Enter the number of ingredients: ");
        int ingredientCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < ingredientCount; i++)
        {
            Console.Write($"Enter the name of ingredient {i + 1}: ");
            string ingredientName = Console.ReadLine();

            Console.Write($"Enter the quantity of {ingredientName}: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.Write($"Enter the unit of measurement for {ingredientName}: ");
            string unit = Console.ReadLine();

            Console.Write($"Enter the number of calories for {ingredientName}: ");
            int calories = int.Parse(Console.ReadLine());

            Console.Write($"Enter the food group for {ingredientName}: ");
            string foodGroup = Console.ReadLine();

            Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
            ingredients.Add(ingredient);
        }

        Console.Write("Enter the number of steps: ");
        int stepCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < stepCount; i++)
        {
            Console.Write($"Enter step {i + 1}: ");
            string step = Console.ReadLine();
            steps.Add(step);
        }
    }

    public void Display()
    {
        Console.WriteLine("Recipe Details");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Ingredients:");

        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Name} - {ingredient.Quantity} {ingredient.Unit}");
        }

        Console.WriteLine("Steps:");

        for (int i = 0; i < steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }

        int totalCalories = ingredients.Sum(i => i.Calories);
        Console.WriteLine($"Total Calories: {totalCalories}");

        if (totalCalories > 300)
        {
            Console.WriteLine("Warning: Total calories exceed 300.");
        }
    }
}
