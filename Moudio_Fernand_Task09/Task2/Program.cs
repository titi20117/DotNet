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
            List<int> obs = new List<int> { 0, 1, 2 , 4, 6, 8, 10, 15, 12, 2};
            Console.WriteLine("length : {0}", obs.Count());
            DynamicArray<int> dynamicArray = new DynamicArray<int>(obs);
            Console.WriteLine("Capacity : {0}", dynamicArray.Capacity);
            Console.ReadKey();
        }
    }

}
