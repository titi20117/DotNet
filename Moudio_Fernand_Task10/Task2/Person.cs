using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public class PersonTimeArgs : EventArgs
    {
        public Person Person { get; set; }
    }
    public delegate void Message(object source, PersonTimeArgs args);
    public class Person
    {
        private string name;
        private int time;

        //public string Name { get { return this.name; } }
        public string Name { get ; set; }
        //public int Time { get { return this.time; } }
        public int Time { get; set; }
        public void Greet(object source, PersonTimeArgs person)
        {
            int time = person.Person.time;
            string nextName = person.Person.name;
            if (time < 12)
                Console.WriteLine("Good Morning, {0}!, {1} said.", nextName, Name);
            else if ((time > 11) && (time < 18))
                Console.WriteLine("Good Afternoon, {0}!, {1} said.", nextName, Name);
            else
                Console.WriteLine("Good Evening, {0}!, {1} said.", nextName, Name);
        }

        public void Forgive(object source, PersonTimeArgs person)
        {
            Console.WriteLine("Good bye, {0}!, {1} said.", person.Person.name, this.name);
        }

        public event Message Came;

        public event Message GoHome;

        public void OnCame()
        {
            Came?.Invoke(this, new PersonTimeArgs() { Person = this });
        }

        public void OnGoHome()
        {
            GoHome?.Invoke(this, new PersonTimeArgs() { Person = this });
        }

        public Person(string name, int time)
        {
            this.name = name;
            this.time = time;
        }

        private void SetOnCame()
        {
            Thread.Sleep(3000);
            Console.WriteLine(Name + " Пришел");
        }
        private void SetOnGoHome()
        {
            Thread.Sleep(6000);
            Console.WriteLine(Name + " идет домой");
        }
        public Person()
        {
            var firstTask = Task.Factory.StartNew(() => {
                SetOnCame();
                
                }, TaskCreationOptions.AttachedToParent)
                .ContinueWith((prevTask) => {
                    prevTask.Wait();
                    Task.WaitAll(prevTask);
                    SetOnGoHome();
                });

            //Task.Factory.StartNew(firstTask)(() =>
            //{
            //    Thread.Sleep(6000);
            //    Console.WriteLine(Name + " идет домой");
            //    OnGoHome(new Person(Name, Time));
            //})
        }
    }
}
