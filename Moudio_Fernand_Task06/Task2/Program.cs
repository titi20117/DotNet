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
            Ring ring = new Ring(0, 0, 3, 10);
            Console.WriteLine("Кольцо с координатом О:({0}, {1})\nВнутренниq радиуc r={2}\nВнешний радиус R={3}"
                , ring.GetX(), ring.GetY(), ring.GetRadius(), ring.GetExternRadius());
            Console.WriteLine("Периметр кольцо P:= {0}", ring.GetPerim());
            Console.WriteLine("Площадь кольцо S:= {0}", ring.GetArea());
            Console.ReadKey();
        }

        public class Round
        {
            protected int x;
            protected int y;
            protected int radius;
            protected double perimetr { get { return 2 * Math.PI * radius; } }
            protected double aire { get { return Math.PI * Math.Pow(radius, 2); } }
            public Round(int X, int Y, int innerRadius)
            {
                this.x = X;
                this.y = Y;
                this.radius = innerRadius;
            }

            public int GetX()
            {
                return x;
            }
            public int GetY()
            {
                return y;
            }

            public int GetRadius()
            {
                return radius;
            }

            public virtual double GetPerim()
            {
                return perimetr;
            }

            public virtual double GetArea()
            {
                return aire;
            }
        }

        public class Ring : Round
        {
            private int secondRadius;
            private double perimetrExtern { get { return 2 * Math.PI * secondRadius; } }
            private double aireExtern { get { return Math.PI * Math.Pow(secondRadius, 2); } }
            public Ring(int X, int Y, int innerRadius, int secondRadius)
                :base(X, Y, innerRadius)
            {
                this.secondRadius = secondRadius;
            }

            public int GetExternRadius()
            {
                return secondRadius;
            }
            public override double GetPerim()
            {
                return perimetrExtern + base.GetPerim();
            }

            public override double GetArea()
            {
                return aireExtern - base.GetArea();

            }

        }
    }
}
