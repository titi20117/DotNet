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
            Person person1 = new Person("Fernand", 7);
            Person person2 = new Person("Anton", 8);
            Person person3 = new Person("Andre", 13);
            Person person4 = new Person("Corine", 18);
            PersonGreeting personGreeting = new PersonGreeting();

            Console.WriteLine("Greeting Person.....");
            personGreeting.PersonGreetedWhenCome += personGreeting.Greet;
            Console.WriteLine("come");
            personGreeting.Greet(person1, new PersonEventArgs { Person = person2});
            personGreeting.Greet(person1, new PersonEventArgs { Person = person3 });
            personGreeting.Greet(person1, new PersonEventArgs { Person = person4 });
            personGreeting.GreetWhenBackHome(person2, new PersonEventArgs { Person = person1 });

            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
