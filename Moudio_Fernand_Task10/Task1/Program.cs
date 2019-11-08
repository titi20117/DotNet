using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "fer", "aaaaa", "db", "da", "sdsd", "d", "aassadaf", "ddssa" };
            SortArrayAscendant<string> array = new SortArrayAscendant<string>();
            array.CustomSort(arr, sortingMethod);
            foreach (var el in arr)
                Console.WriteLine(el);
            Console.ReadKey();
        }

        static bool sortingMethod(string s1, string s2)
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
