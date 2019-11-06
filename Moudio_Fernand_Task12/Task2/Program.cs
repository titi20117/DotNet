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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Epam_DotNetCourse_2019\DotNetCourse\Moudio_Fernand_Task12\Task1");
            dir.Create();
        }
    }
}
