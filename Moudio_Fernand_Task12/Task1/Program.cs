using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\loude\Desktop\Epam2019Materiels\прак12\disposable_task_file.txt";

            string[] readText = File.ReadAllLines(path);
            ReadFile(readText);

            string[] arr = new string[readText.Length];
            arr = SetSquareValueInFile(readText);

            ModifyFile(path, arr);
            
            Console.ReadKey();
        }

        static string[] SetSquareValueInFile(string[] readText)
        {
            string[] arr = new string[readText.Length];
            for (int i = 0; i < readText.Length; i++)
            {
                int num = Int32.Parse(readText[i]);
                int numSquare = num * num;
                arr[i] = numSquare.ToString();
            }
            return arr;
        }

        static void ModifyFile(string path, string[] arr)
        {
            string[] createText = arr;
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, createText);
            }
            else
            {
                File.Delete(path);
                File.WriteAllLines(path, createText);
            }
        }

        static void ReadFile(string[] readText)
        {
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }
    }
}
