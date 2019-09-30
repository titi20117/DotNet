using StringLibrary;
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
            Console.WriteLine("Введите текст : ");
            string input = Console.ReadLine();
            Console.Write("Средняя длина слова во введенной текстовой строке L = {0}", AverageLengthWord(input));
            Console.ReadKey();
        }

        private static int AverageLengthWord(string input)
        {
            int sum = 0;
            string[] partsInput = Stringer.GetArrayString(input);
            for (int i = 0; i < partsInput.Length; i++)
            {
                sum += partsInput[i].Length;
            }
            return sum / partsInput.Length;
        }
    }
}
