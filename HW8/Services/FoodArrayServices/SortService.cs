using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class SortService : ISort
    {
        private QuestionToUser _questionToUser = new ();
        public void SortArray(Food[] array)
        {
            _questionToUser.TypeOfSort();
            var sortTypes = 4;
            var chosenOption = sortTypes.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    SortArrayByCalories(array);
                    break;
                case 2:
                    SortArrayByProteins(array);
                    break;
                case 3:
                    SortArrayByFats(array);
                    break;
                case 4:
                    SortArrayByCarbohydrates(array);
                    break;
            }
        }

        public void SortArrayByCalories(Food[] array)
        {
            _questionToUser.SortOption();
            var sortOption = 2;
            var chosenOption = sortOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    SortArrayByCaloriesAscending(array);
                    break;
                case 2:
                    SortArrayByCaloriesDownward(array);
                    break;
            }
        }

        public void SortArrayByProteins(Food[] array)
        {
            _questionToUser.SortOption();
            var sortOption = 2;
            var chosenOption = sortOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    SortArrayByProteinsAscending(array);
                    break;
                case 2:
                    SortArrayByProteinsDownward(array);
                    break;
            }
        }

        public void SortArrayByFats(Food[] array)
        {
            _questionToUser.SortOption();
            var sortOption = 2;
            var chosenOption = sortOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    SortArrayByFatsAscending(array);
                    break;
                case 2:
                    SortArrayByFatsDownward(array);
                    break;
            }
        }

        public void SortArrayByCarbohydrates(Food[] array)
        {
            _questionToUser.SortOption();
            var sortOption = 2;
            var chosenOption = sortOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    SortArrayByCarbohydratesAscending(array);
                    break;
                case 2:
                    SortArrayByCarbohydratesDownward(array);
                    break;
            }
        }

        public void SortArrayByCaloriesAscending(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Calories > array[j].Calories)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByCaloriesDownward(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Calories < array[j].Calories)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByProteinsAscending(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Proteins > array[j].Proteins)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByProteinsDownward(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Proteins < array[j].Proteins)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByFatsAscending(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Fats > array[j].Fats)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByFatsDownward(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Fats < array[j].Fats)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByCarbohydratesAscending(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Carbohydrates > array[j].Carbohydrates)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }

        public void SortArrayByCarbohydratesDownward(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Carbohydrates < array[j].Carbohydrates)
                    {
                        var container = array[i];
                        array[i] = array[j];
                        array[j] = container;
                    }
                }
            }
        }
    }
}
