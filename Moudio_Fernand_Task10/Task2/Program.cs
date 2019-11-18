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
        private static List<Person> _peopleInOffice = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("Greeting Person.....");

            Person person1 = new Person() { Name = "Фернанд", Time = new DateTime(2014, 6, 14, 6, 32, 0) };
            person1.GoToWork();
            _peopleInOffice.Add(person1);

            
            Person person2 = new Person() { Name = "Антон", Time = new DateTime(2014, 6, 14, 9, 32, 0) };
            person2.GoToWork();
            _peopleInOffice.Add(person2);

            Person person3 = new Person() { Name = "Юля", Time = new DateTime(2014, 6, 14, 12, 32, 0) };
            _peopleInOffice.Add(person3);

            Person person4 = new Person() { Name = "Наталия", Time = new DateTime(2014, 6, 14, 18, 32, 0) };
            _peopleInOffice.Add(person4);

            Office office = new Office(_peopleInOffice);
            //persons.Remove(person2);
            //SayGoodBye(persons, person2);
            //Thread.Sleep(3000);

            //persons.Remove(person1);
            //SayGoodBye(persons, person1);
            //Thread.Sleep(3000);

            Console.ReadKey();
        }
    }
}
