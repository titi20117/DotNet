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
            int[] arr = new int[20];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            Console.WriteLine("Maximun : " + FindMaxElement(arr));
            Console.WriteLine("Minimun : " + FindMinElement(arr));
            Console.ReadKey();

        }

        static int FindMaxElement(int[] arr)
        {
            int max = -1;
            foreach (int element in arr)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        static int FindMinElement(int[] arr)
        {
            int min = 10000;
            foreach (int element in arr)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        static int[] sortArray(int[] arr)
        {
            int[] ordArray = new int[arr.Length];
            int min = 100000;
            bool test = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == FindMinElement(arr))
                {
                    ordArray[i] = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    test = true;
                }
                else
                {

                }
            }
            
        }
    }
}
