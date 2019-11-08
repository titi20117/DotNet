using System;
using System.Threading;

namespace Task2
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; set; }
    }
    public class PersonGreeting
    {
        public delegate void PersonGreetedEventHandler(Person person, PersonEventArgs args);

        public event PersonGreetedEventHandler PersonGreetedWhenCome;

        public event PersonGreetedEventHandler PersonGreetedWhenBackHome;

        private string myName;
        private int myTime;

        private void GetNameAndTime(Person person)
        {
            myName = person.Name;
            myTime = person.Time;
        }
        public void Greet(Person person, PersonEventArgs e)
        {
            //Thread.Sleep(3000);
            int time = e.Person.Time;
            string nextName = e.Person.Name;
            if (time < 12)
                Console.WriteLine("Good Morning, {0}!, {1} said.", nextName, person.Name);
            else if ((time > 11) && (time < 18))
                Console.WriteLine("Good Afternoon, {0}!, {1} said.", nextName, person.Name);
            else
                Console.WriteLine("Good Evening, {0}!, {1} said.", nextName, person.Name);
        }

        public void GreetWhenBackHome(Person person, PersonEventArgs e)
        {
            string nextName = e.Person.Name;
            Console.WriteLine("До свидания!...{0}!, {1} said.", nextName, person.Name);
        }

        protected virtual void OnPersonGreetedWhenCome(Person person)
        {
            if (PersonGreetedWhenCome != null)
                PersonGreetedWhenCome(person, new PersonEventArgs() { Person = person });
        }

        protected virtual void OnPersonGreetedWhenBackHome(Person person)
        {
            if (PersonGreetedWhenBackHome != null)
                PersonGreetedWhenBackHome(person, new PersonEventArgs() { Person = person });
        }
    }
}
