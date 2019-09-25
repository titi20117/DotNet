using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сумма всех чисел меньше 1000 равно : " + FindSum(1000));
            Console.ReadKey();
        }

        static int FindSum (int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
