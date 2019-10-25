using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "is good to know something new, i like to play a football, go to the training, listen music " +
                "with my friends is good to know something new, i like to play a football, " +
                "i like to play a football, go to the training, listen music";
            Words<string> word = new Words<string>(text);

            foreach (var ws in word.TextToArray)
            {
                word.Append(ws);
            }
            Console.WriteLine(word.ElementAt(5));
            Console.ReadKey();
        }
    }
}
