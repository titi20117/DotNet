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
            Ring ring = new Ring(0, 0, 5, 10);
            Console.WriteLine(ring.ToString());
            Console.ReadKey();
        }

        public class Round
        {
            protected int x;
            protected int y;
            protected int radius;
            protected double perimetr { get { return 2 * Math.PI * GetRadius(); } }
            protected double aire { get { return Math.PI * Math.Pow(GetRadius(), 2); } }
            public Round(int X, int Y, int radius)
            {
                this.x = X;
                this.y = Y;
                this.radius = radius;
            }

            public int GetRadius()
            {

                if (this.radius < 0)
                {
                    return 0;
                }
                return this.radius;
            }

            public int GetX()
            {
                return x;
            }
            public int GetY()
            {
                return y;
            }

            public virtual double GetPerim()
            {
                return this.perimetr;
            }

            public virtual double GetArea()
            {
                return this.aire;
            }
        }

        public class Ring : Round
        {
            private int secondRadius;
            private double perimetrExtern { get { return 2 * Math.PI * GetSecondRadius(); } }
            private double aireExtern { get { return Math.PI * Math.Pow(GetSecondRadius(), 2); } }
            public Ring(int X, int Y, int radius, int secondRadius)
                :base(X, Y, radius)
            {
                this.secondRadius = secondRadius;
            }

            private int GetSecondRadius()
            {
                if (this.secondRadius < 0)
                {
                    return 0;
                }
                return this.secondRadius;
            }
            public override double GetPerim()
            {
                return perimetrExtern + base.GetPerim();
            }

            public override double GetArea()
            {
                return aireExtern - base.GetArea();
            }
            public override string ToString()
            {
                return string.Format("Координаты Центр O({0}, {1})\nВнутренний радиус r1 : {2}\nВнешний радиус r2 : {3}\nСуммарная длина внешней и внутренней границ кольца S : {4}\nПлощадь кольца A : {5}", 
                        GetX(), GetY(), GetRadius(), GetSecondRadius(), GetPerim(), GetArea()
                    );
            }

        }
    }
}
