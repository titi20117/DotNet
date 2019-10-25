using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinkedList<int> linkList = new LinkedList<int>(numbers);
            
            PrintList(list);
            RemoveEachSecondItem<int>(list);
            RemoveEachSecondItem<int>(linkList);
            Console.ReadKey();
        }

        static void RemoveEachSecondItem<T>(ICollection<int> list)
        {
            bool delete = false;
            while (list.Count > 1)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    if (delete) 
                    {
                        list.Remove(list.ElementAt(i--));
                    }    
                    delete = !delete;
                }
                PrintList(list);
            }
        }
        static void PrintList(IEnumerable<int> list)
        {
            foreach (var item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }
    }
}
