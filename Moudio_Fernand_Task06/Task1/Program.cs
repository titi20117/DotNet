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
            Employee employee = new Employee("Fernand", "Elisee", "Moudio", "1995", "2015", "Programmer");
            Console.WriteLine("{0}", employee);
            Console.ReadKey();
        }

        public class User
        {
            protected string firstName { get; set; }
            protected string middleName { get; set; }
            protected string lastName { get; set; }
            protected string dateOfBirth { get; set; }
            private int age { get { return int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dateOfBirth); } }

            public User(string firstName, string middleName, string lastName, string dateOfBirth)
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
            private string dateStartWork;
            private string position;
            public int workExperience { get { return int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dateStartWork); } }

            public Employee(string firstName, string middleName, string lastName, string dateOfBirth, string dateStartWork, string thePosition)
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
