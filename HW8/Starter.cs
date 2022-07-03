using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Starter
    {
        private readonly FoodArray _foodArray;
        private readonly IOutput _output;
        private readonly ISort _sort;
        private readonly IFilter _filter;

        public Starter(IOutput output, ISort sort, IFilter filter)
        {
            _foodArray = new FoodArray();
            _output = output;
            _sort = sort;
            _filter = filter;
        }

        public void Start()
        {
            _output.OutputArray(_foodArray.ArrayOfFood);
            _sort.SortArray(_foodArray.ArrayOfFood);
            _output.OutputArray(_foodArray.ArrayOfFood);
            _output.OutputArray(_filter.FilterAray(_foodArray.ArrayOfFood));
        }
    }
}
