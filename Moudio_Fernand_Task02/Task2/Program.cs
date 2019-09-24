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
            int number;
            do
            {
                Console.Write("Введите число N : ");
                string num = Console.ReadLine();                
                number = ConvertValue(num);
                CheckValue(number);
            } while (number <= 0);

            ShowPicture(number);
        }

        static void ShowPicture(int number)
        {
            string start = "*";
            if (number == 1)
                Console.WriteLine(start);
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(start);
                    start = start + "*";
                }
            }
        }

        static int ConvertValue(string value)
        {
            int convertedValue;
            int myValue = 0;
            if (Int32.TryParse(value, out convertedValue))
            {
                myValue += convertedValue;
            }
            else
            {
                myValue = -1;
            }
            return myValue;
        }

        static void CheckValue(int value)
        {

            if (value <= 0)
            {
                Console.WriteLine("Ошибка, повторите пожалуйста !");
            }
        }
    }
}
