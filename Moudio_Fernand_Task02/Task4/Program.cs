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
            int number;
            do
            {
                Console.Write("Введите число N : ");
                string num = Console.ReadLine();
                number = ConvertValue(num);
                CheckValue(number);
            } while (number <= 0);

            ShowTrianglePicture(number);
            Console.ReadKey();
        }

        static void ShowTrianglePicture(int number)
        {
            for (int i = 1; i <= number; i++)
            {

                ShowPicture(i);  
            }
        }
        static void ShowPicture(int number)
        { 
            string start = "*";
            if (number == 1)
                Console.WriteLine("*");
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = i; j <= (2 * number - 1); j++)
                    {
                        if (j == Math.Ceiling((2 * number - 1) / 2.0))
                        {
                            Console.Write(start);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    start = start + "**";
                    Console.WriteLine();
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
