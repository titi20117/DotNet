using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N : ");
            string num = Console.ReadLine();
            Console.WriteLine("Factorail {0} = {1}", Int32.Parse(num), Mathi.Factorial(Int32.Parse(num)));
            Console.WriteLine("Math pow n^4 = {0}", Mathi.Power(Int32.Parse(num), 4));
            Console.ReadKey();
        }
    }
}
