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

            Person person1 = new Person() { Name = "Фернанд", Time = 8 };
            List<Person> persons = new List<Person>();
            persons.Add(person1);
            Thread.Sleep(3000);
            
            Person person2 = new Person() { Name = "Антон", Time = 12};
            SayHi(persons, person2);
            persons.Add(person2);
            Thread.Sleep(3000);

            Person person3 = new Person() { Name = "Юля", Time = 14 };
            SayHi(persons, person3);
            persons.Add(person3);
            Thread.Sleep(3000);

            Person person4 = new Person() { Name = "Наталия", Time = 16 };
            SayHi(persons, person4);
            persons.Add(person4);
            Thread.Sleep(3000);

            RemoveSayHi(persons, person2);
            persons.Remove(person2);
            SayGoodBye(persons, person2);
            Thread.Sleep(3000);

            persons.Remove(person1);
            SayGoodBye(persons, person1);
            Thread.Sleep(3000);

            Console.ReadKey();
        }

        private static void ComeToOffice(Person person)
        {
            foreach(Person p in _peopleInOffice)
            {
                person.Came += p.Greet;
                person.GoHome += p.Forgive;
            }
            person.OnCame();
            _peopleInOffice.Add(person);            
        }

        private static void WentOut(Person person)
        {
            _peopleInOffice.Remove(person);
            person.OnGoHome();
            foreach (Person p in _peopleInOffice)
            {
                person.Came -= p.Greet;
                person.GoHome -= p.Forgive;
            }
        }

        static void SayHi(List<Person> persons, Person personCome)
        {
            foreach (var el in persons) { 
                personCome.Came += el.Greet;
            }
        }

        static void RemoveSayHi(List<Person> persons, Person personCome)
        {
            foreach (var el in persons)
                personCome.Came -= el.Greet;
        }

        static void SayGoodBye(List<Person> persons, Person personBack)
        {
            for (int i = 0; i < persons.Count(); i++)
            {
                personBack.GoHome += persons[i].Forgive;
            }
        }
    }
}
