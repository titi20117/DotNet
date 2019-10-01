using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "<ba>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            DeleteTag(text);
            Console.ReadKey();
        }

        static void DeleteTag(string text)
        {
            Regex regex = new Regex(@"</?\w+\s*[^<>]*>");
            MatchCollection match = regex.Matches(text);
            if (match.Count > 0)
            {
                foreach (Match el in match)
                {
                    Console.WriteLine(el.Value);
                    text = text.Replace(el.Value, "_");
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено !");
            }
            Console.WriteLine(text);
        }
    }
}
