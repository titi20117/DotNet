using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void OnCame(Person p, DateTime time);
    public delegate void OnLeave(Person p);
    public class Person
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public event OnCame OnCame;
        public event OnLeave OnLeave;

        public void GoToWork()
        {
            //logic
            OnCame?.Invoke(this, Time);
        }

        public void GoHome()
        {
            // logic
            OnLeave?.Invoke(this);
        }

        public void SayHello(string otherPerson, DateTime time)
        {
            if (time.Hour < 12)
                Console.WriteLine("Good Morning, {0}!, {1} said.", otherPerson, Name);
            else if ((time.Hour > 11) && (time.Hour < 18))
                Console.WriteLine("Good Afternoon, {0}!, {1} said.", otherPerson, Name);
            else
                Console.WriteLine("Good Evening, {0}!, {1} said.", otherPerson, Name);
        }

        public void SayGoodBye(string otherName)
        {
            Console.WriteLine("Good bye, {0}!, {1} said.", otherName, Name);
        }
    }
}
