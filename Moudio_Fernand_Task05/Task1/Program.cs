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
            User user = new User();

            Console.Write("Введите фамилию : ");
            user.firstName = Console.ReadLine();

            Console.Write("Введите имя : ");
            user.middleName = Console.ReadLine(); ;

            Console.Write("Введите отчество : ");
            user.lastName = Console.ReadLine();

            Console.Write("Введите дату рождению : ");
            user.dateOfBirth = Console.ReadLine();

            Console.WriteLine("Проверка");
            Console.WriteLine("User FIO : {0}", user.GetFullNameUser());
            Console.WriteLine("User лет : {0}", user.GetAge());
            Console.ReadKey();
        }

        public class User
        {
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string dateOfBirth { get; set; }
            private int age { get { return int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dateOfBirth); } }

            public int GetAge()
            {
                return age;
            }
            
            public string GetFullNameUser()
            {
                return this.firstName + " " + this.middleName + " " + this.lastName;
            }
        }
    }
}
