using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Cola : Drink
    {
        public Cola(string foodName, double calories, double proteins, double fats, double carbohydrates, bool presenceOfAlcohol, string brand)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfAlcohol = false;
            Brand = brand;
        }

        public string Brand { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр.\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит алкоголь: {PresenceOfAlcohol}\t Бренд: {Brand}");
        }
    }
}
