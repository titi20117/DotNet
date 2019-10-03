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
            //User user = new User("Fernand");
            Console.WriteLine("My Name : {0}", user.GetName());
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

        }
    }
}
