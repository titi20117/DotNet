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
            bool removingItem = dynamicArray.Remove("Adamou");
            Console.WriteLine(removingItem);
            Console.ReadKey();
        }
    }
}
