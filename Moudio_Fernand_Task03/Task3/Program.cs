using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
            }
            Console.Write("Одномерная массива M : ");
            DisplayArray(array);
            Console.WriteLine();
            Console.WriteLine("Cумма неотрицательных элементов S = " + SumNonNegativeElement(array));
            Console.ReadKey();
        }

        static int SumNonNegativeElement(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        static void DisplayArray(int[] array)
        {
            foreach(int el in array)
            {
                Console.Write(el + "    ");
            }
        }
    }
}
