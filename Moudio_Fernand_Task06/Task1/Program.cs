using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
                (
                    "Fernand", 
                    "Elisee", 
                    "Moudio", 
                    new DateTime(1995, 12, 25), 
                    new DateTime(2013, 11, 23), 
                    "Programmer"
                );
            Console.WriteLine("{0}", employee);
            Console.ReadKey();
        }

        public class User
        {
            protected string firstName { get; set; }
            protected string middleName { get; set; }
            protected string lastName { get; set; }
            protected DateTime dateOfBirth { get; set; }
            private int age { get { return (DateTime.Now - dateOfBirth).Days/365; } }

            public User(string firstName, string middleName, string lastName, DateTime dateOfBirth)
            {
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;
                this.dateOfBirth = dateOfBirth;
            }

            public int GetAge()
            {
                return age;
            }

            public string GetFullNameUser()
            {
                return this.firstName + " " + this.middleName + " " + this.lastName;
            }

            public override string ToString()
            {
                return (String.Format("Сотрудник: {0}\nВозраст : {1}", this.GetFullNameUser(), this.GetAge()));
            }
        }

        public class Employee : User
        {
            private DateTime dateStartWork;
            private string position;
            public int workExperience { get { return (DateTime.Now - dateStartWork).Days/365; } }

            public Employee(string firstName, string middleName, string lastName, DateTime dateOfBirth, DateTime dateStartWork, string thePosition)
                :base(firstName, middleName, lastName, dateOfBirth)
            {
                this.dateStartWork = dateStartWork;
                this.position = thePosition;
            }

            public string GetPosition()
            {
                return position;
            }

            public override string ToString()
            {
                return (String.Format("Сотрудник : {0}\nВозраст : {1}\nОпыт работы : {2}\nДолжность : {3}", this.GetFullNameUser(),
                    this.GetAge(), this.workExperience, this.GetPosition()));
            }

        }
    }
}
