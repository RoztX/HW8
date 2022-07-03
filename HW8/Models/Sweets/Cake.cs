using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Cake : Sweetness
    {
        public Cake(string foodName, double calories, double proteins, double fats, double carbohydrates, bool presenceOfChocolate)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfChocolate = presenceOfChocolate;
        }
    }
}
