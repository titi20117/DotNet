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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\loude\Desktop\Epam2019Materiels\прак12");
            dir.Create();

            string filePath = Path.Combine(dir.FullName, "disposable_task_file.txt");
            string filePath2 = Path.Combine(dir.FullName, "disposable_task_file2.txt");
            UTF8Encoding encoding = new UTF8Encoding();
            //File.ReadAllLines()
            //File.WriteAllLines()

            using(FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                byte[] buffer = new byte[fs.Length];
                while(fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    string fileContent = encoding.GetString(buffer);
                    Console.WriteLine(fileContent);
                    char[] delimitedChars = { '\t', '\n' };
                    string[] tab = fileContent.Split(delimitedChars);
                    //for (int i = 0; i < tab.Length; i++)
                    //{
                    //    int num = Int32.Parse(tab[i]);
                    //    tab[i] = (num * num).ToString();
                    //}
                    foreach (var el in tab)
                    {
                        int num = Int32.Parse(el);
                        Console.WriteLine(num * num);

                    }
                    //byte[] info = encoding.GetBytes(tab);
                    //fs.Write(info, 0, info.Length);
                }
            }
            Console.ReadKey();
        }
    }
}
