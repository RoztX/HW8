using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Salad : Dish
    {
        public Salad(string foodName, double calories, double proteins, double fats, double carbohydrates, bool vegetarian)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Vegetarian = vegetarian;
        }
    }
}
