using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class QuestionToUser
    {
        public void TypeOfSort()
        {
            Console.WriteLine("Выберете интересующий вас тип сортировки:\n1.Сортировка по каллориям\n2.Сордировка по белкам\n3.Сортировка по жирам\n4.Сортировка по углеводам");
        }

        public void SortOption()
        {
            Console.WriteLine("Выберите интересующий вас вариант сортировки:\n1.Сортировка по возрастанию\n2.Сортировка по убыванию");
        }

        public void TypeOfFilter()
        {
            Console.WriteLine("Выберете интересующий вас пизнак по которому будет отфильтрован массив:\n1.Фильтрация по каллориям\n2.Фильтрация по белкам\n3.Фильтрация по жирам\n4.Фильтрация по углеводам");
        }

        public void FilterOption()
        {
            Console.WriteLine("Выберете интересующий вас вариант фильтрации:\n1.Фильтрация по минимально допустимому занчению\n2.Фильтрация по максимально допустимому значению\n3.Фильтрация по диапазону значений");
        }

        public void MinValueFilter()
        {
            Console.WriteLine("Введите минимально допустимое значение для фильтрации");
        }

        public void MaxValueFilter()
        {
            Console.WriteLine("Введите максимально допустимое значение для фильтрации");
        }
    }
}
