using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Starter
    {
        public void Start()
        {
            var foodArray = new FoodArray();
            var outputService = new OutputService();
            var sortService = new SortService();
            var filterService = new FilterService();

            outputService.OutputArray(foodArray.ArrayOfFood);
            sortService.SortArray(foodArray.ArrayOfFood);
            outputService.OutputArray(foodArray.ArrayOfFood);
            outputService.OutputArray(filterService.FilterAray(foodArray.ArrayOfFood));
        }
    }
}
