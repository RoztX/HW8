using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public static class MyException
    {
        public static int GetFromConcole(this int maxValue, int minVaiue = 0)
        {
            var contain = 0;
            var flag = true;
            while (flag)
            {
                contain = Convert.ToInt32(Console.ReadLine());
                if (contain > minVaiue && contain <= maxValue)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid value entered");
                }
            }

            return contain;
        }
    }
}
