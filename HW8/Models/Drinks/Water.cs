using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Water : Drink
    {
        public Water(string foodName, double calories, double proteins, double fats, double carbohydrates, bool carbonated)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfAlcohol = false;
            Carbonated = carbonated;
        }

        public bool Carbonated { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр.\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит алкоголь: {PresenceOfAlcohol}\t Газированная: {Carbonated}");
        }
    }
}
