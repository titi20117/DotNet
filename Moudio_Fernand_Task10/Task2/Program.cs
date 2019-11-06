using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person fernand = new Person("Fernand", 7);
            Person elisee = new Person("Elisee", 8);
            elisee.Came += fernand.Greet;

            Person sylvain = new Person("Syvain", 14);
            sylvain.Came += fernand.Greet;
            sylvain.Came += elisee.Greet;

            Person corine = new Person("Corine", 18);
            corine.Came += fernand.Greet;
            corine.Came += elisee.Greet;

            fernand.GoHome += elisee.Forgive;

            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
