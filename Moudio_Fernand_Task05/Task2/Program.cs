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
            Round circle = new Round(5, 7, 3);
            Console.WriteLine("Длина окружности P = {0}", circle.perimetr);
            Console.WriteLine("Площадь окружности S = {0}", circle.aire);
            Console.ReadKey();
        }
        public class Round
        {
            private int x;
            private int y;
            private int radius;
            public double perimetr { get { return 2 * Math.PI * radius; } }
            public double aire { get { return Math.PI * Math.Pow(radius, 2); } }
            public Round (int X, int Y, int rad)
            {
                this.x = X;
                this.y = Y;
                this.radius = rad;
            }
        }
    }
}
