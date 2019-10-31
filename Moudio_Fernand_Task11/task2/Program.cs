using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
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
            Employee employee2 = new Employee
                (
                    "Fernand",
                    "Elisee",
                    "Moudo",
                    new DateTime(1995, 12, 25),
                    new DateTime(2013, 11, 23),
                    "Programmer"
                );
            Console.WriteLine("{0}", employee);
            Console.WriteLine("Compare employee1 = employee2 : {0}", employee.Equals(employee2));
            Console.ReadKey();
        }
    }
}
