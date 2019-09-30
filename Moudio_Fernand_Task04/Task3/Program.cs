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
            double value = 12345.67891;
            Console.WriteLine("Формат отображения даты и времени");
            Console.WriteLine("invariant");
            GetCultureName("invariant", dateTimeIn);
            Console.WriteLine("ru");
            GetCultureName("ru-RU", dateTimeIn);
            Console.WriteLine("en");
            GetCultureName("en-EN", dateTimeIn);
            Console.WriteLine("\n\nФормат отображения числовых данных");
            Console.WriteLine("invariant");
            GetCultureName("invariant", value);
            Console.Write("En\n");
            GetCultureName("en-En", value);
            Console.WriteLine("Ru\n");
            GetCultureName("ru-RU", value);
            Console.ReadKey();
        }

        private static void GetCultureName(string cultureName, DateTime date)
        {
            if (cultureName == "invariant")
            {
                Console.WriteLine("Date formatted for the {0} culture: {1}",
                           cultureName, date.ToString("f", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Date formatted for the {0} culture: {1}",
                           cultureName, date.ToString("f", CultureInfo.CreateSpecificCulture(cultureName)));

            }
        }

        private static void GetCultureName(string cultureName, double value)
        {
            if (cultureName == "invariant")
            {
                Console.WriteLine("Date formatted for the {0} culture: {1}",
                           cultureName, value.ToString("f", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Date formatted for the {0} culture: {1}",
                           cultureName, value.ToString("f", CultureInfo.CreateSpecificCulture(cultureName)));

            }
        }
    }
}
