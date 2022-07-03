using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class ChocolateBar : Sweetness
    {
        public ChocolateBar(string foodName, double calories, double proteins, double fats, double carbohydrates, string brand, bool presenceOfNnuts)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfChocolate = true;
            Brand = brand;
            PresenceOfNnuts = presenceOfNnuts;
        }

        public string Brand { get; set; }
        public bool PresenceOfNnuts { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит шоколад{PresenceOfChocolate}\tБренд: {Brand}\tСодержит орехи: {PresenceOfNnuts}");
        }
    }
}
