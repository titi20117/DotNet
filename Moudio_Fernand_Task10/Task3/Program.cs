using System;
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
            string[] array = new string[] { "bacd", "abcd", "ff", "rlk", "r", "cghjk", "dghjk" };
            SortingModule<string> arr = new SortingModule<string>();
            SortingModule<string>[] SortedArray = new SortingModule<string>[] { };

            //arr.CustomSort(SortedArray, new Func<string, string, bool>(sortingMethod));
            //arr.SortingFinished += arr_SortingFinished;
            //arr.RunSortInNewThread(SortedArray, new Func<string, string, bool>(sortingMethod));
            SortingModule<string> sortingModule = new SortingModule<string>();
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }

        private static bool sortingMethod(string arg1, string arg2)
        {
            throw new NotImplementedException();
        }
    }
}
