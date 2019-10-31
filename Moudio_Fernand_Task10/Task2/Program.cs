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

            Person sylvain = new Person("Syvain", 14);
            Person corine = new Person("Corine", 18);

            fernand.Time = sylvain.Time;
            sylvain.Came += fernand.Greet;
            
            elisee.Time = sylvain.Time; 
            sylvain.Came += elisee.Greet;

            fernand.Time = corine.Time;
            corine.Came += fernand.Greet;

            elisee.Time = corine.Time;
            corine.Came += elisee.Greet;

            Thread.Sleep(6000);
            Console.ReadKey();
        }
    }
}
