using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
    }

    public class Round
    {
        protected int x;
        protected int y;
        protected int radius;
        public int R
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                    radius = value;
            }
        }
        protected double Perimetr { get { return 2 * Math.PI * GetRadius(); } }
        protected double Aire { get { return Math.PI * Math.Pow(GetRadius(), 2); } }
        public Round(int X, int Y, int radius)
        {
            this.x = X;
            this.y = Y;
            this.radius = radius;
        }

        public int GetRadius()
        {
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
            return this.Perimetr;
        }

        public virtual double GetArea()
        {
            return this.Aire;
        }
    }

    public class Ring : Round
    {
        private int innerRadius;
        public int InnerR
        {
            get { return innerRadius; }
            set
            {
                if (value >= 0)
                    innerRadius = value;
            }
        }
        private double PerimetrIntern { get { return 2 * Math.PI * InnerR; } }
        private double AereaIntern { get { return Math.PI * Math.Pow(InnerR, 2); } }
        public Ring(int X, int Y, int innerR, int radius)
            : base(X, Y, radius)
        {
            this.innerRadius = innerR;
        }

        private int GetInnerRadius()
        {
            return this.innerRadius;
        }
        public override double GetPerim()
        {
            return base.GetPerim() + PerimetrIntern;
        }

        public override double GetArea()
        {
            return base.GetArea() - AereaIntern;
        }
        public override string ToString()
        {
            return string.Format("Координаты Центр O({0}, {1})\nВнутренний радиус r1 : {2}\nВнешний радиус r2 : {3}\nСуммарная длина внешней и внутренней границ кольца S : {4}\nПлощадь кольца A : {5}",
                    GetX(), GetY(), GetInnerRadius(), GetRadius(), GetPerim(), GetArea()
                );
        }

    }
}
