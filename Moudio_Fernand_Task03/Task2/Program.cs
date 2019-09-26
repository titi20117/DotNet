using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int [2,2,3] 
            {
                {
                    { -1, 2, -3 },
                    { 14, -5, 6 }
                },
                { 
                    { -1, 2, -3 }, 
                    { 14, -5, 6 } 
                }
            };
            
            Console.WriteLine("Исходный массив А: ");
            DisplayArray(array);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("результат: ");
            DisplayArray(ChangePositiveElement(array));
            Console.ReadKey();
        }

        static int[,,] ChangePositiveElement(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                            array[i, j, k] = 0;
                    }
                }
            }
            return array;
        }

        static void DisplayArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(".....................................");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + "    ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
