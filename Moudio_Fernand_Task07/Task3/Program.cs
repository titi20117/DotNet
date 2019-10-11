﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndexableSeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression); 
            Console.WriteLine("Progression index: 5");
            PrintIndex(progression);

            IIndexableSeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);
            Console.WriteLine("List index: 5");
            PrintIndex(list);
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        static void PrintIndex(IIndexable index)
        {
            Console.WriteLine(index[3]);
        }
    }

    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    public class ArithmeticalProgression : IIndexableSeries
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }

        public double this[int index]
        {
            get
            {
                return start + step * index;
            }
        }
    }

    public class List : IIndexableSeries
    {
        private double[] series;
        private int currentIndex;

        public List(double[] series)
        {
            this.series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index]
        {
            get { return series[index]; }
        }
    }

    public interface IIndexable
    {
        double this[int index] { get; }
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }
}
