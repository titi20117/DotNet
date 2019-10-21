using System;
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
            DynamicArray<string> dynamicArray = new DynamicArray<string>();
            string[] myNames = { "Fernand", "Elisee", "Moudio", "Jean", "Antoine", "Jules", "Elise", "Elie" };
            foreach (string el in myNames)
                dynamicArray.Add(el);
            dynamicArray.Add("Maroufatou");
            string[] myMiddleNames = { "Adamou", "Assouma", "Njoli", "Mbende" };
            dynamicArray.AddRange(myMiddleNames);
            dynamicArray.Insert("Castro", 3);
            bool removingItem = dynamicArray.Remove("Adamou");
            Console.WriteLine("Element2 {0}", dynamicArray.GetElementArray(2));
            Console.WriteLine("Capacity {0}", dynamicArray.Capacity);
            Console.WriteLine("Length {0}", dynamicArray.Length);
            Console.WriteLine(removingItem);

            Console.ReadKey();
        }
    }
}
