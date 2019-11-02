using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public class PersonTimeArgs : EventArgs
    {
        public Person Person { get; set; }
    }
    public delegate void Message(string name, PersonTimeArgs args);
    public class Person
    {
        public string Name { get; private set; }
        public int Time { get; set; }
        public void Greet(string nextPerson, PersonTimeArgs person)
        {
            int time = person.Person.Time;
            Console.WriteLine(person.Person.Name);
            if (time < 12)
                Console.WriteLine("Good Morning, {0}!, {1} said.", nextPerson, Name);
            else if((time > 11) && (time < 18))
                Console.WriteLine("Good Afternoon, {0}!, {1} said.", nextPerson, Name);
            else
                Console.WriteLine("Good Evening, {0}!, {1} said.", nextPerson, Name);
        }
        public event Message Came;

        public void OnCame(Person person)
        {
            
            if (Came != null)
                Came(Name, new PersonTimeArgs() { Person = person});
        }

        public Person(string name, int time)
        {
            Name = name;
            Time = time;
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                OnCame(new Person(name, time));
            });
        }
    }
}
