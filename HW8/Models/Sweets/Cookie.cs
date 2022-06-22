using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Cookie : Sweetness
    {
        public Cookie(string foodName, double calories, double proteins, double fats, double carbohydrates, bool presenceOfChocolate, string type)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            PresenceOfChocolate = presenceOfChocolate;
            Type = type;
        }

        public string Type { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит шоколад{PresenceOfChocolate}\tТип :{Type}");
        }
    }
}
