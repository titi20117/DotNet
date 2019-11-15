using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы программы\r\n1.Режим наблюдателя\r\n2.Режим отката\r\nДля выхода из программы нажмите любую кнопку");
            string key = Console.ReadLine();
            if (key == "1")
            {
                Observer();
                Console.ReadKey();
            }
            if (key == "2")
            {
                Console.WriteLine("Введите дату и время в формате MM.dd.yyyy HH mm");
                Console.Write("Дата : ");
                string date = Console.ReadLine();
                RoolBackFile(date, pathSystem, path);
                Console.ReadKey();
            }
        }
        private static string path = @"C:\Epam_DotNetCourse_2019\DotNetCourse\Moudio_Fernand_Task12\Task2\OriganalDir\Original_Files";
        private static string pathSystem = @"C:\Epam_DotNetCourse_2019\DotNetCourse\Moudio_Fernand_Task12\Task2\OriganalDir\Dest";
        public static void Observer()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                Console.WriteLine("Включён режим наблюдателя");
                watcher.Path = path;
                watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";
                FileSystemEventHandler fileCreateEventHandler = new FileSystemEventHandler(OnChanged);
                FileSystemEventHandler fileDeleteEventHandler = new FileSystemEventHandler(OnDelete);
                RenamedEventHandler fileRenameEventHandler = new RenamedEventHandler(OnRenamed);
                FileSystemEventHandler fileChangedEventHandler = new FileSystemEventHandler(Changed);
                watcher.Created += fileCreateEventHandler;
                watcher.Deleted += fileDeleteEventHandler;
                watcher.Renamed += fileRenameEventHandler;
                watcher.Changed += fileChangedEventHandler;

                watcher.EnableRaisingEvents = true;
                Console.WriteLine("Нажмите q для выхода из программы.");
                while (Console.Read() != 'q') ;
                watcher.Created -= fileCreateEventHandler;
                watcher.Deleted -= fileDeleteEventHandler;
                watcher.Renamed -= fileRenameEventHandler;
                watcher.Changed -= fileChangedEventHandler;
            }
            //we can and IDisposible work with
            //watcher.Dispose();
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
            String[] files = Directory.GetFiles(FromDir, "*.txt");

            //refaire les . et / par les espaces
            ToDir += '\\' + SetDirName(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            CreateDirectory(ToDir);
            foreach (string currentFile in files)
            {
                string fileName = currentFile.Substring(FromDir.Length + 1);
                string sourceFileName = Path.Combine(FromDir, fileName);
                string destFileName = Path.Combine(ToDir, fileName);
                File.Copy(sourceFileName, destFileName, true);
            }
        }

        static string SetDirName (string dir)
        {
            string result = "";
            Regex regex = new Regex(@":");
            MatchCollection matches = regex.Matches(dir);
            foreach(Match match in matches)
            {
                string val = match.Value;
                result = dir.Replace(match.Value, " ");
            }

            return result;
        }
        static void CreateDirectory(string path)
        {
            try
            {
                //Determine whether the directory exists
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Путь уже существует.");
                    return;
                }

                //try to create the directory
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        static void RoolBackFile(String time, string FromDir, string ToDir)
        {
            string dir = FromDir + '\\' + time; 
            String[] files = Directory.GetFiles(dir, "*.txt");
            DeleteFileFolder(ToDir);
            foreach (string currentFile in files)
            {
                string fileName = Path.GetFileName(currentFile);
                string sourceFileName = Path.Combine(dir, fileName);
                string destFileName = Path.Combine(ToDir, fileName);
                File.Copy(sourceFileName, destFileName, true);
            }
        }

        static void DeleteFileFolder(string dir) 
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            foreach (FileInfo file in di.GetFiles()) 
            {
                file.Delete();
            }
        }
    }
}
