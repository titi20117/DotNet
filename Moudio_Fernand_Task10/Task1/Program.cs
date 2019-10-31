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
            string[] arr = { "fer", "aaaaa", "db", "da", "sdsd", "d", "aassadaf", "ddssa" };
            SortArrayAscendant sortArray = new SortArrayAscendant(arr);
            sortArray.SortOperation(sortArray.Array, sortArray.GetArrayLengthAscending);
            sortArray.SortOperation(sortArray.Array, sortArray.GetArrayWordAscending);
            foreach (var el in sortArray.Array)
                Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
