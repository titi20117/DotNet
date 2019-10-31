using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void Message(string name);
    class Person
    {
        public string Name { get; private set; }
        public int Time { get; set; }
        public void Greet(string nextPerson)
        {
            if (Time < 12)
                Console.WriteLine("Good Morning, {0}!, {1} said.", nextPerson, Name);
            else if((Time > 11) && (Time < 18))
                Console.WriteLine("Good Afternoon, {0}!, {1} said.", nextPerson, Name);
            else
                Console.WriteLine("Good Evening, {0}!, {1} said.", nextPerson, Name);
        }
        public event Message Came;

        public void OnCame()
        {
            if (Came != null)
                Came(Name);
        }

        public Person(string name, int time)
        {
            Name = name;
            Time = time;
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                OnCame();
            });
        }
    }
}
