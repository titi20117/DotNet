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
            Console.Write("Напишите значению сторону a прямоугольника a = ");
            string sideA = Console.ReadLine();
            Console.Write("Напишите значению сторону b прямоугольника b = ");
            string sideB = Console.ReadLine();
            int area = FindAreaRectangle(sideA, sideB);
            Console.WriteLine("Площадь прямоугольника S = " + area);
        }

        static int FindAreaRectangle (string sideA, string sideB)
        {
            int area = 0;
            int sideNameA, sideNameB;
            if (Int32.TryParse(sideA, out sideNameA))
            {
                if (Int32.TryParse(sideB, out sideNameB))
                {
                    if (sideNameA <= 0 || sideNameB <= 0)
                    {
                        Console.WriteLine("Ошибка, значение не может быть отрицательным или нуль");
                    }
                    else
                    {
                        area += sideNameA * sideNameB;
                    }
                }
                else
                {
                    Console.WriteLine("значение b не число !");
                }
            }
            else
            {
                Console.WriteLine("значение a не число !");
            }
            return area;
        }
    }
}
