using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "В 7:55 я встал, позавтракал и к 10:77 пошел на работу.";
            Console.WriteLine(text);
            Console.WriteLine("Время в тексте присутствует {0} раз.", GetCount(text));
            Console.ReadKey();
        }

        static int GetCount (string text)
        {
            int count = 0;
            Regex reg = new Regex(@"(00|[0-9]|1[0-9]|2[0-3]):([0-9]|[0-5][0-9])");
            MatchCollection match = reg.Matches(text);
            count += match.Count;
            return count;
        }
    }
}
