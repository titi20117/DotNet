using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeIn = DateTime.Now;
            Console.WriteLine("Формат отображения даты и времени");
            Console.WriteLine("ru vs en");
            GetCultureName("ru-RU", "en-EN");
            Console.WriteLine("en vs invariant");
            GetCultureName("en-EN", "InvariantCulture");
            Console.WriteLine("ru vs invariant");
            GetCultureName("ru-RU", "InvariantCulture");
            Console.WriteLine("Формат отображения числовых данных");
            Console.WriteLine("ru vs en");
            Console.WriteLine("en vs invariant");
            Console.WriteLine("ru vs invariant");
            Console.ReadKey();
        }

        private static void GetCultureName(string cultureName1, string cultureName2)
        {
            DateTime dateTimeIn = DateTime.Now;
            CultureInfo firstCulture = new CultureInfo(cultureName1);
            CultureInfo secondCulture = new CultureInfo(cultureName2);
            Console.WriteLine("Date formatted for the {0} culture: {1}",
                           firstCulture.Name, dateTimeIn.ToString("f", firstCulture));
            Console.WriteLine("Date formatted for the {0} culture: {1}",
                           secondCulture.Name, dateTimeIn.ToString("f", secondCulture));
            //CultureInfo invC = CultureInfo.InvariantCulture;
        }
    }
}
