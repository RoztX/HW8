using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class FoodArray
    {
        public Food[] ArrayOfFood { get; set; } =
        {
            new Salad("Салат вегетарианский ", 160d, 5d, 9.23d, 14.2d, true),
            new Salad("Салат из морепрод.   ", 99.40d, 9.04d, 5.16d, 5.64, false),
            new Shawarma("Шаурма из рестика   ", 553d, 24.85d, 11.55d, 86.1d, false),
            new Shawarma("Шаурма от хача      ", 553d, 24.85d, 11.55d, 86.1d, true),
            new Steak("Стейк              ", 208.07d, 22.59d, 13.33d, 0.08d, false, "Medium rare"),
            new Cola("Кола               ", 38d, 0.1d, 0d, 10d, false, "The Coca-Cola Company"),
            new Cola("Другая кола       ", 48.70d, 0.47d, 0.41d, 10.38d, false, "PepsiCo"),
            new Cola("Дешевая кола       ", 1.1d, 0d, 0d, 1.1d, false, "Розумний вибір"),
            new Water("Миргородська       ", 0d, 0d, 0d, 0d, true),
            new Wine("Вино               ", 70.08d, 0d, 0d, 5.71d, "Розовое", "Сухое"),
            new Wine("Вино               ", 88d, 0.2d, 5d, 9.6d, "Красное", "Полусладкое"),
            new Wine("Вино               ", 82.21d, 0.31d, 0.03d, 1.65d, "Белое", "Полусухое"),
            new Cookie("Печенье            ", 446.84d, 5.12d, 23.61d, 52.97d, true, "Печенье с шоколадом"),
            new Cookie("Печенье            ", 450d, 6.2d, 18.1d, 65.9d, false, "Овсяное печенье"),
            new ChocolateBar("Шоколадка молочная ", 535d, 6.8d, 31d, 56d, "Milka", false),
            new Cake("Торт Киевский Рошен", 439d, 3.97d, 26.60d, 48.08d, false)
        };
    }
}
