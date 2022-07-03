using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Drink : Food
    {
        public bool PresenceOfAlcohol { get; set; }

        public override void MySpecification()
        {
            Console.WriteLine($"Название: {FoodName}\tКаллорийность: {Calories}Ккал./100гр.\tБелки: {Proteins}гр./100гр.\tЖиры: {Fats}гр./100гр.\tУглеводы: {Carbohydrates}гр./100гр.\tСодержит алкоголь: {PresenceOfAlcohol}");
        }
    }
}
