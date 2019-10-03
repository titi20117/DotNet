using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.sideA = 4;
            triangle.sideB = 6;
            triangle.sideC = 8;
            Console.WriteLine("Треуголник со сторонами а: {0}; а: {1}; а: {2}", triangle.sideA, triangle.sideB, triangle.sideC);
            Console.WriteLine("Периметр треуголника P:= {0}", triangle.GetLength().ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Площадь треуголника S:= {0}", triangle.GetArea().ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.ReadKey();
        }

        public class Triangle
        {
            public int sideA { get; set; }
            public int sideB { get; set; }
            public int sideC { get; set; }

            public int GetLength()
            {
                return sideA + sideB + sideC;
            }

            public double GetArea()
            {
                double area = 0;
                double height = 0;
                height = Math.Sqrt(Math.Pow(sideB, 2) - Math.Pow(((Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / 2), 2));
                
                area = (sideC * height) / 2;
                return area;
            }
        }
    }
}
