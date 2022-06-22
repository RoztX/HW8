using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Shawarma : Dish
    {
        public Shawarma(string foodName, double calories, double proteins, double fats, double carbohydrates, bool spicy)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Vegetarian = false;
            Spicy = spicy;
        }

        public bool Spicy { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр.\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tЯвляется вегетарианским: {Vegetarian}\tЯвляется острым: {Spicy}");
        }
    }
}
