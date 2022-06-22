using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class FilterService : IFilter
    {
        private QuestionToUser _questionToUser = new QuestionToUser();
        public Food[] FilterAray(Food[] array)
        {
            _questionToUser.TypeOfFilter();
            var filterTypes = 4;
            var chosenOption = filterTypes.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    return FilterArrayByCalories(array);
                case 2:
                    return FilterArrayByProteins(array);
                case 3:
                    return FilterArrayByFats(array);
                case 4:
                    return FilterArrayByCarbohydrates(array);
                default:
                    return FilterArrayByCalories(array);
            }
        }

        public Food[] FilterArrayByCalories(Food[] array)
        {
            _questionToUser.FilterOption();
            var filterOption = 3;
            var chosenOption = filterOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    return FilterArrayByCaloriesFromMin(array);
                case 2:
                    return FilterArrayByCaloriesFromMax(array);
                case 3:
                    return FilterArrayByCaloriesInRange(array);
                default:
                    return FilterArrayByCaloriesInRange(array);
            }
        }

        public Food[] FilterArrayByProteins(Food[] array)
        {
            _questionToUser.FilterOption();
            var filterOption = 3;
            var chosenOption = filterOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    return FilterArrayByProteinsFromMin(array);
                case 2:
                    return FilterArrayByProteinsFromMax(array);
                case 3:
                    return FilterArrayByProteinInRange(array);
                default:
                    return FilterArrayByProteinInRange(array);
            }
        }

        public Food[] FilterArrayByFats(Food[] array)
        {
            _questionToUser.FilterOption();
            var filterOption = 3;
            var chosenOption = filterOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    return FilterArrayByFatsFromMin(array);
                case 2:
                    return FilterArrayByFatsFromMax(array);
                case 3:
                    return FilterArrayByFatsInRange(array);
                default:
                    return FilterArrayByFatsInRange(array);
            }
        }

        public Food[] FilterArrayByCarbohydrates(Food[] array)
        {
            _questionToUser.FilterOption();
            var filterOption = 3;
            var chosenOption = filterOption.GetFromConcole();
            switch (chosenOption)
            {
                case 1:
                    return FilterArrayByCarbohydratesFromMin(array);
                case 2:
                    return FilterArrayByCarbohydratesFromMax(array);
                case 3:
                    return FilterArrayByCarbohydratesInRange(array);
                default:
                    return FilterArrayByCarbohydratesInRange(array);
            }
        }

        public Food[] FilterArrayByCaloriesFromMin(Food[] array)
        {
            var maxValueCalories = 553;
            _questionToUser.MinValueFilter();
            var chosenOption = maxValueCalories.GetFromConcole();
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Calories)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Calories)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByCaloriesFromMax(Food[] array)
        {
            var maxValueCalories = 553;
            var minValueCalories = 0;
            _questionToUser.MaxValueFilter();
            var chosenOption = maxValueCalories.GetFromConcole(minValueCalories);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Calories)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Calories)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByCaloriesInRange(Food[] array)
        {
            var maxValueCalories = 553;
            var minValueCalories = 0;
            _questionToUser.MinValueFilter();
            var chosenOptionMin = maxValueCalories.GetFromConcole(minValueCalories);
            _questionToUser.MaxValueFilter();
            var chosenOptionMax = maxValueCalories.GetFromConcole(chosenOptionMin);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Calories && chosenOptionMin >= array[i].Calories)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Calories && chosenOptionMin >= array[i].Calories)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByProteinsFromMin(Food[] array)
        {
            var maxValueProteins = 24;
            _questionToUser.MinValueFilter();
            var chosenOption = maxValueProteins.GetFromConcole();
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Proteins)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Proteins)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByProteinsFromMax(Food[] array)
        {
            var maxValueProteins = 24;
            var minValueProteins = 0;
            _questionToUser.MaxValueFilter();
            var chosenOption = maxValueProteins.GetFromConcole(minValueProteins);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Proteins)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Proteins)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByProteinInRange(Food[] array)
        {
            var maxValueProteins = 24;
            var minValueProteins = 0;
            _questionToUser.MinValueFilter();
            var chosenOptionMin = maxValueProteins.GetFromConcole(minValueProteins);
            _questionToUser.MaxValueFilter();
            var chosenOptionMax = maxValueProteins.GetFromConcole(chosenOptionMin);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Proteins && chosenOptionMin >= array[i].Proteins)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Proteins && chosenOptionMin >= array[i].Proteins)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByFatsFromMin(Food[] array)
        {
            var maxValueFats = 31;
            _questionToUser.MinValueFilter();
            var chosenOption = maxValueFats.GetFromConcole();
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Fats)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Fats)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByFatsFromMax(Food[] array)
        {
            var maxValueFats = 31;
            var minValueFats = 0;
            _questionToUser.MaxValueFilter();
            var chosenOption = maxValueFats.GetFromConcole(minValueFats);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Fats)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Fats)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByFatsInRange(Food[] array)
        {
            var maxValueFats = 31;
            var minValueFats = 0;
            _questionToUser.MinValueFilter();
            var chosenOptionMin = maxValueFats.GetFromConcole(minValueFats);
            _questionToUser.MaxValueFilter();
            var chosenOptionMax = maxValueFats.GetFromConcole(chosenOptionMin);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Fats && chosenOptionMin >= array[i].Fats)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Fats && chosenOptionMin >= array[i].Fats)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByCarbohydratesFromMin(Food[] array)
        {
            var maxValueCarbohydrates = 86;
            _questionToUser.MinValueFilter();
            var chosenOption = maxValueCarbohydrates.GetFromConcole();
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Carbohydrates)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption <= array[i].Carbohydrates)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByCarbohydratesFromMax(Food[] array)
        {
            var maxValueCarbohydrates = 86;
            var minValueCarbohydrates = 0;
            _questionToUser.MaxValueFilter();
            var chosenOption = maxValueCarbohydrates.GetFromConcole(minValueCarbohydrates);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Carbohydrates)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOption >= array[i].Carbohydrates)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }

        public Food[] FilterArrayByCarbohydratesInRange(Food[] array)
        {
            var maxValueCarbohydrates = 86;
            var minValueCarbohydrates = 0;
            _questionToUser.MinValueFilter();
            var chosenOptionMin = maxValueCarbohydrates.GetFromConcole(minValueCarbohydrates);
            _questionToUser.MaxValueFilter();
            var chosenOptionMax = maxValueCarbohydrates.GetFromConcole(chosenOptionMin);
            var arraySize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Carbohydrates && chosenOptionMin >= array[i].Carbohydrates)
                {
                    arraySize++;
                }
            }

            Food[] arrayReturn = new Food[arraySize];
            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (chosenOptionMax <= array[i].Carbohydrates && chosenOptionMin >= array[i].Carbohydrates)
                {
                    arrayReturn[counter++] = array[i];
                }
            }

            return arrayReturn;
        }
    }
}
