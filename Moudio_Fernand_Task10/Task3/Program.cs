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
            //SortingModule<string>[] SortedArray = new SortingModule<string>[] { };

            arr.CustomSort(array, sortingMethod);
            arr.SortingFinished += arr_SortingFinished;
            arr.RunSortInNewThread(array, sortingMethod);
            //SortingModule<string> sortingModule = new SortingModule<string>();
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }

        private static void arr_SortingFinished(object sender, SortingEventArgs<string> e)
        {
            Console.WriteLine("thread is finish!");
        }

        private static bool sortingMethod(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
    }
}
