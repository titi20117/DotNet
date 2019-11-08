using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы программы\r\n1.Режим наблюдателя\r\n2.Режим отката\r\nДля выхода из программы нажмите любую кнопку");
            if (Console.Read() == '1')
            {
                Observer();
                Console.ReadKey();
            }
            if (Console.Read() == '2')
            {
                Console.WriteLine("В разработке");
                Console.ReadKey();
            }
        }
        private static string path = "C:\\Exchange";
        private static string pathSystem = "C:\\ExchangeSystem";
        private static FileSystemWatcher watcher = new FileSystemWatcher();
        public static void Observer()
        {
            Console.WriteLine("Включён режим наблюдателя");
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.EnableRaisingEvents = true;
            watcher.Filter = "*.*";
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDelete);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Changed += new FileSystemEventHandler(Changed);

            watcher.EnableRaisingEvents = true;
            Console.WriteLine("Нажмите q для выхода из программы.");
        }
        private static void Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Произошло изменение файла {e.Name} \r\nДействие произведенное с ним: {e.ChangeType} \r\nПуть до файла: {e.FullPath}");
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Новый файл: {e.Name} \r\nДействие произведенное с ним: {e.ChangeType} \r\nПуть до файла: {e.FullPath} \r\n");
            CopyDir(path, pathSystem);
        }
        private static void OnDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Удален файл: {e.Name}\r\nДействие произведенное с ним: {e.ChangeType}\r\nУдален файл из: {e.FullPath}\r\n");
            CopyDir(path, pathSystem);
        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.OldFullPath} renamed to {e.FullPath}\r\n");
            CopyDir(path, pathSystem);
        }

        static void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }
    }
}
