using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Wine : Drink
    {
        public Wine(string foodName, double calories, double proteins, double fats, double carbohydrates, string color, string sweetness)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfAlcohol = true;
            Color = color;
            Sweetness = sweetness;
        }

        public string Color { get; set; }
        public string Sweetness { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр.\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит алкоголь: {PresenceOfAlcohol}\tЦвет: {Color}\tСухость: {Sweetness}");
        }
    }
}