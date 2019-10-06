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
            Employee employee = new Employee("Fernand", "Elisee", "Moudio", "1995", 5, "Programmer");
            Console.WriteLine("Сотрудник : {0}", employee.GetFullNameUser());
            Console.WriteLine("Возраст : {0} года", employee.GetAge());
            Console.WriteLine("опыт работы : {0} лет", employee.GetWorkExperience());
            Console.WriteLine("должность : {0}", employee.GetPosition());
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
        }

        public class Employee : User
        {
            private int workExperience;
            private string position;

            public Employee(string firstName, string middleName, string lastName, string dateOfBirth, int theWorkExperience, string thePosition)
                :base(firstName, middleName, lastName, dateOfBirth)
            {
                this.workExperience = theWorkExperience;
                this.position = thePosition;
            }

            public int GetWorkExperience()
            {
                return this.workExperience;
            }

            public string GetPosition()
            {
                return position;
            }

        }
    }
}
