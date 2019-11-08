using System;
using System.Threading.Tasks;

namespace Task2
{
    //public class PersonTimeArgs : EventArgs
    //{
    //    public Person Person { get; set; }
    //}
    //public delegate void Message(object source, EventArgs args);
    public class Person
    {
        private string name;
        private int time;

        public string Name { get { return this.name; } }
        public int Time { get { return this.time; } }
        //public void Greet(PersonTimeArgs person)
        //{
        //    int time = person.Person.time;
        //    string nextName = person.Person.name;
        //    if (time < 12)
        //        Console.WriteLine("Good Morning, {0}!, {1} said.", nextName, this.name);
        //    else if ((time > 11) && (time < 18))
        //        Console.WriteLine("Good Afternoon, {0}!, {1} said.", nextName, this.name);
        //    else
        //        Console.WriteLine("Good Evening, {0}!, {1} said.", nextName, this.name);
        //}

        //public void Forgive(PersonTimeArgs person)
        //{
        //    Console.WriteLine("Good bye, {0}!, {1} said.", person.Person.name, this.name);
        //}

        //public event Message Came;

        //public event Message GoHome;

        //public void OnCame(Person person)
        //{

        //    //Came(new PersonTimeArgs() { Person = person });
        //    Came?.Invoke(this, new PersonTimeArgs() { Person = person });
        //}

        //public void OnGoHome(Person person)
        //{
        //    if (GoHome != null)
        //    {
        //        GoHome(new PersonTimeArgs() { Person = person });
        //    }
        //}

        public Person(string name, int time)
        {
            this.name = name;
            this.time = time;
            //Console.WriteLine(this.name + " Came");
            //var task1 = Task.Factory.StartNew(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine(this.name + " Came");
            //    OnCame(new Person(name, time));
            //});
            //task1.ContinueWith(task =>
            //{
            //    Thread.Sleep(6000);
            //    Console.WriteLine(this.name + " Go home");
            //    OnGoHome(new Person(name, time));
            //});
        }
    }
}
