using System;

namespace task2
{
    public class User
    {
        protected string FirstName { get; set; }
        protected string MiddleName { get; set; }
        protected string LastName { get; set; }
        protected DateTime DateOfBirth { get; set; }
        private int age { get { return (DateTime.Now - DateOfBirth).Days / 365; } }

        public User(string firstName, string middleName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetFullNameUser()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }

        public override string ToString()
        {
            return (String.Format("Сотрудник: {0}\nВозраст : {1}", this.GetFullNameUser(), this.GetAge()));
        }
    }
}