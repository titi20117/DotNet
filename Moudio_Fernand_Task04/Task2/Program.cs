using StringLibrary;
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
            Console.Write("Введите первую строку: ");
            string input1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string input2 = Console.ReadLine();
            string[] partsInput1 = Stringer.GetArrayString(input1);
            string[] partsInput2 = Stringer.GetArrayString(input2);
            Console.Write("Результирующая строка:");
            Console.Write(ResultingString(partsInput1, partsInput2, input1).Trim());
            Console.ReadKey();
        }

        private static string ResultingString(string[] partsInput1, string[] partsInput2, string input1)
        {
            string secondInput = "";
            foreach (string el in partsInput2)
                secondInput += el;
            char[] secondInputArr = GetCharFromString(RemoveRepeatCharInString(secondInput));
            for (int  k = 0; k < secondInputArr.Length; k++)
            {
                input1 = input1.Replace(secondInputArr[k].ToString(), secondInputArr[k] + "" + secondInputArr[k]);
            }
            return input1;
        }

        static string RemoveRepeatCharInString(string text)
        {
            char[] charText = GetCharFromString(text);
            //ascii
            bool[] test = new bool[256];
            StringBuilder builder = new StringBuilder();
            foreach (char ch in charText)
            {
                if (!test[ch])
                {
                    test[ch] = true;
                    builder.Append(ch);
                }
            }
            return builder.ToString();
        }

        static char[] GetCharFromString(string text)
        {
            return text.ToCharArray();
        }
    }
}
