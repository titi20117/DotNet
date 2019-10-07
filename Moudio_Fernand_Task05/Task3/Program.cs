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
            Triangle triangle = new Triangle { sideA = 4, sideB = 6, sideC = 8 };
            Console.WriteLine("Треуголник со сторонами A: {0}; B: {1}; C: {2}", triangle.sideA, triangle.sideB, triangle.sideC);
            Console.WriteLine("Периметр треуголника P:= {0}", triangle.GetLength());
            Console.WriteLine("Площадь треуголника S:= {0}", triangle.GetArea());
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
