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
            Console.Write(ResultingString(partsInput1, partsInput2).Trim());
            Console.ReadKey();
        }

        private static string ResultingString(string[] partsInput1, string[] partsInput2)
        {
            string secondInput = "";
            foreach (string el in partsInput2)
                secondInput += el;
            char[] secondInputArr = GetCharFromString(RemoveRepeatCharInString(secondInput));
            string resultString = "";
            for (int i = 0; i < partsInput1.Length; i++)
            {
                for (int  k = 0; k < secondInputArr.Length; k++)
                {
                    if (partsInput1[i].Contains(secondInputArr[k]))
                    {
                        string temp = secondInputArr[k] + "" + secondInputArr[k];
                        string mm = partsInput1[i][partsInput1[i].IndexOf(secondInputArr[k])].ToString();
                        partsInput1[i] = partsInput1[i].Replace(mm, temp);
                    }

                }
                resultString += partsInput1[i] + " ";
            }
            return resultString;
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
