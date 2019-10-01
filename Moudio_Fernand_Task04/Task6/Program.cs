using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число N = ");
            string input = Console.ReadLine();
            DisplayFormatNumber(input);
            Console.ReadKey();
        }

        private static void DisplayFormatNumber(string input)
        {
            Regex regex1 = new Regex(@"\w");
            Regex regex2 = new Regex(@"^\d+");
            Regex regex3 = new Regex(@"^-?\d");
            Regex regex4 = new Regex(@"e");

            Match match = regex1.Match(input);
            //isMatch
            if (match.Success)
            {
                Console.WriteLine("Это не число");
            }
            else
            {
                match = regex4.Match(input);
                if (match.Success)
                    Console.WriteLine("{0}: {1}", input, "Это число в научной нотации");
                else
                {
                    match = regex3.Match(input);
                    if (match.Success)
                        Console.WriteLine("{0}: {1}", input, "Это число в обычной нотации");
                    else
                        Console.WriteLine("{0}: {1}", input, "Это число в обычной нотации");
                }
            }
        }
    }
}
