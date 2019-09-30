using StringLibrary;
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
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            DateTime stopTime = DateTime.Now;
            Console.WriteLine("start: " + startTime.Millisecond);
            Console.WriteLine("stop: " + stopTime.Millisecond);
            Console.WriteLine("скорость работы String : {0} {1}", FindExecutionSpeed(AddStatus(startTime), AddStatus(stopTime)), "ms");
            startTime = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopTime = DateTime.Now;
            Console.WriteLine("start: " + startTime.Millisecond);
            Console.WriteLine("stop: " + stopTime.Millisecond);
            Console.WriteLine("скорость работы StringBuilder : {0} {1}", FindExecutionSpeed(AddStatus(startTime), AddStatus(stopTime)), "ms");
            Console.ReadKey();
        }

        static long FindExecutionSpeed (long start, long stop)
        {
            return stop - start;
        } 

        static long AddStatus(DateTime date)
        {
            return date.Millisecond;
        }
    }
}
