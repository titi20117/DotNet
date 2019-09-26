using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] matrix = FillArray(size);
            Console.WriteLine("Матрица : ");
            DisplayArray(matrix);
            Console.WriteLine("Сумма элементов матрица, стоящих на четных позициях S = " + SumElementsArray(matrix));
            Console.ReadKey();
        }

        static int SumElementsArray(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        static int[,] FillArray(int size)
        {
            int[,] array = new int[size, size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }
            return array;
        }

        static void DisplayArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
