﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ingredient
{
    public string Name { get; }
    public double Quantity { get; }
    public string Unit { get; }
    public int Calories { get; }
    public string FoodGroup { get; }

    public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Calories = calories;
        FoodGroup = foodGroup;
    }
}

