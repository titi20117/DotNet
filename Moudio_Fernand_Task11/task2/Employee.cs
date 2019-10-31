using System;

namespace task2
{
    public class Employee : User, IEquatable<Employee>
    {
        private DateTime DateStartWork;
        private string position;
        public int workExperience { get { return (DateTime.Now - DateStartWork).Days / 365; } }
        public bool Equals(Employee obj)
        {
            if (obj == null)
                return false;
            if (this == obj) return true;
            if (this.GetFullNameUser() == obj.GetFullNameUser()) return true;
            return false;
        }

        public Employee(string firstName, string middleName, string lastName, DateTime dateOfBirth, DateTime dateStartWork, string thePosition)
            : base(firstName, middleName, lastName, dateOfBirth)
        {
            this.DateStartWork = dateStartWork;
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