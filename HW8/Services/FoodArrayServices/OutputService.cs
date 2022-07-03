using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class OutputService : IOutput
    {
        public void OutputArray(Food[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}\t");
                array[i].MySpecification();
            }
        }
    }
}
