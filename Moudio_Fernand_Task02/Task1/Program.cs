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
            int sideNameA;
            do
            {
                Console.Write("Напишите значению сторону a прямоугольника a = ");
                string sideA = Console.ReadLine();
                sideNameA = ConvertValue(sideA);
                CheckValue(sideNameA);
            } while (sideNameA == 1);

            int sideNameB;
            do
            {
                Console.Write("Напишите значению сторону a прямоугольника b = ");
                string sideB = Console.ReadLine();
                sideNameB = ConvertValue(sideB);
                CheckValue(sideNameB);
            } while (sideNameB == 1);

            ResultMessage(sideNameA, sideNameB);
        }

        static int FindAreaRectangle (int sideA, int sideB)
        {
            return sideA * sideB;
        }

        static int ConvertValue (string value)
        {
            int convertedValue = 0;
            if (Int32.TryParse(value, out convertedValue))
            {
                convertedValue += convertedValue;
            }
            else
            {
                convertedValue = 1;
            }
            return convertedValue;
        }

        static void CheckValue (int value)
        {
            if (value == 1)
            {
                Console.WriteLine("значение не число!");
            }
        }

        static void ResultMessage (int valueA, int valueB)
        {
            if (valueA <= 0 || valueB <= 0)
            {
                Console.WriteLine("Ошибка, значение не может быть отрицательным или нуль");
            }
            else
            {
                int area = FindAreaRectangle(valueA, valueB);
                Console.WriteLine("Площадь прямоугольника S = " + area);
            }
        }
    }
}
