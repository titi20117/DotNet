using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }
            Console.Write("исходной массив М : ");
            DisplayInitialArray(arr);
            Console.WriteLine();
            Console.Write("Сортировка по возрастанию массив М : ");
            DisplaySortArray(arr);
            Console.WriteLine();
            Console.WriteLine("Максимальное значение массива: " + FindMaxElementArray(arr));
            Console.WriteLine("Минимальное значение массива: " + FindMinElementArray(arr));
            Console.ReadKey();

        }

        static int[] SortArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        static int FindMaxElementArray(int[] arr)
        {
            return arr[arr.Length - 1];
        }

        static int FindMinElementArray(int[] arr)
        {
            return arr[0];
        }

        static void DisplayInitialArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + "   ");
            }
        }
        static void DisplaySortArray (int[] arr)
        {
            foreach(int element in SortArray(arr))
            {
                Console.Write(element + "   ");
            }
        }
    }
}
